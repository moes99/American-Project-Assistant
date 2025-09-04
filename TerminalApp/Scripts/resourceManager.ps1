# Get current directory path and remove any quotes
param(
    [Parameter(Mandatory = $true)]
    [string]$projectPath,
    [Parameter(Mandatory = $true)]
    [string]$operation,
    [Parameter(Mandatory = $true)]
    [string]$resourcesFolder,
    [Parameter(Mandatory = $true)]
    [array]$menu,
    [Parameter(Mandatory = $true)]
    [hashtable]$acronyms,
    [hashtable]$subMenu,
    [hashtable]$subAcronyms,
    [hashtable]$units
)

# Display a menu for user to choose an operation
function Show-Menu {
    param(
        [string]$prompt,
        [array]$selectedMenu,
        [hashtable]$selectedAcronyms
    )

    Write-Host $prompt
    for ($i = 0; $i -lt $selectedMenu.Count; $i++) {
        Write-Host "$($i + 1). $($selectedAcronyms[$selectedMenu[$i]])"
    }

    $option = [int] (Read-Host "Enter option number")
    while (-Not ($option -gt 0 -and $option -le $selectedMenu.Count)) {
        $option = [int] (Read-Host "Invalid option. Please enter a valid option number")
    }

    return $option
}

function Get-Datasheets {
    param (
        [string]$folderPath,
        [hashtable]$userInput
    )

    # Create container for matched datasheets
    $matchedDatasheets = @()

    # Get children items in the folder
    $datasheets = Get-ChildItem -Path $folderPath -Filter "*.pdf"
    foreach ($datasheet in $datasheets) {
        $fileName = $datasheet.Name -replace ".pdf", ""
        $fileName = $fileName -split "-"

        # $fileName will be: @("Type", "Manufacturer", "Model Nb", "(Range 1 / Value 1)_(Range 2 / Value 2)_...", "Descriptor 1_Descriptor 2_...")
        $specsMatch = Test-MatchSpecs -fileSpecs ($fileName[3] -split "_") -userSpecs $userInput.specs
        $descriptorMatch = $true
        if ($userInput.descriptors.Count -eq 0) {
            $descriptorMatch = $true
        }
        elseif ($fileName.Count -gt 4) {
            $descriptorMatch = Test-MatchDescriptors -fileDescriptors ($fileName[4] -split "_") -userDescriptors $userInput.descriptors
        }
        else {
            $descriptorMatch = $true
        }

        if ($specsMatch -and $descriptorMatch) {
            $matchedDatasheets += $datasheet
        }
    }

    return $matchedDatasheets
}

function Test-MatchSpecs {
    param(
        [array]$fileSpecs,
        [array]$userSpecs
    )
    $match = $false
    for ($i = 0; $i -lt $fileSpecs.Count; $i++) {
        if ($fileSpecs[$i] -like "*TO*") {
            $range = $fileSpecs[$i] -split "TO"
            $min = [double]$range[0]
            $max = [double]$range[1]
            $match = ($userSpecs[$i] -ge $min -and $userSpecs[$i] -le $max)
        }
        else {
            $match = ($userSpecs[$i] -eq [double]$fileSpecs[$i])
        }
    }
    return $match
}

function Test-MatchDescriptors {
    param(
        [array]$fileDescriptors,
        [array]$userDescriptors
    )
    $match = $false
    foreach ($descriptor in $fileDescriptors) {
        if (-Not ($userDescriptors -contains $descriptor)) {
            $match = $false
            break
        }
        else {
            $match = $true
        }
    }
    return $match
}

# Load projectInfo.json
$projectInfo = $null
if (Test-Path -Path "$projectPath/projectInfo.json") {
    $projectInfo = Get-Content -Path "$projectPath/projectInfo.json" | ConvertFrom-Json
}
else {
    Write-Host "projectInfo.json does not exist! Cannot proceed.`nPlease restart the assistant."
    exit
}

# If operation is "template", ask user for state and copy the appropriate CAD template
if ($operation -eq "template") {
    # Destination and templates folder paths
    $destinationPath = Join-Path -Path $projectPath -ChildPath "Working Folder\MP\DWGs"
    $templatesFolder = Join-Path -Path $resourcesFolder -ChildPath "Templates"

    # Determine which template to copy based on user input
    $option = Show-Menu -prompt "Which type of code does this project use? Choose from the below options." -selectedMenu $menu -selectedAcronyms $acronyms

    # Save code type to projectInfo.json
    $projectInfo.CodeType = $acronyms[$menu[$option - 1]]
    $projectInfo | ConvertTo-Json | Set-Content "$projectPath/projectInfo.json"

    # Point to the right template and create its path
    $selectedTemplate = $menu[$option - 1] + "-MP-DD.dwg"
    $selectedTemplatePath = Join-Path -Path $templatesFolder -ChildPath $selectedTemplate

    # Check if destination folder exists
    Write-Host "Checking if DWGs folder exists..."
    if (Test-Path -Path $destinationPath) {
        Write-Host "DWGs folder exists! Checking if a file by the name of MP-DD.dwg exists..."
        # Check if file already exists
        if (-Not (Test-Path -Path $"$destinationPath/MP-DD.dwg")) {
            if (-Not (Test-Path -Path $selectedTemplatePath)) {
                Write-Host "The selected template does not exist! Please check the templates folder."
                exit
            }
            Write-Host "Copying template..."
            Copy-Item -Path $selectedTemplatePath -Destination "$destinationPath/MP-DD.dwg" -Force
            Write-Host "The selected template has been copied successfully. You can find it inside the DWGs folder under the name MP-DD.dwg.`nDon't forget to rename the codes as per the state's code!"
        }
        else {
            Write-Host "MP-DD.dwg already exists! Cannot copy template."
        }
    }
    else {
        Write-Host "DWGs folder does not exist! Cannot copy template!"
    }
}

# If operation is "datasheet", ask user for type of datasheet and copy the appropriate one
elseif ($operation -eq "datasheet") {
    # Destination and datasheets folder paths
    $destinationPath = Join-Path -Path $projectPath -ChildPath "Working Folder\MP\Selection"
    $datasheetsFolder = Join-Path -Path $resourcesFolder -ChildPath "Datasheets"

    # Determine which datasheet to copy based on user input
    $option = Show-Menu -prompt "Which type of equipment datasheet would you like to copy? Choose from the below options." -selectedMenu $menu -selectedAcronyms $acronyms
    $selectedEquipment = $menu[$option - 1]
    $datasheetsFolder = Join-Path -Path $datasheetsFolder -ChildPath $selectedEquipment

    # If selected equipment is anything other than WH, add \Mechanical to the destination path; otherwise, add \Plumbing
    if ($selectedEquipment -ne "WH") {
        $destinationPath = Join-Path -Path $destinationPath -ChildPath "Mechanical"
    }
    else {
        $destinationPath = Join-Path -Path $destinationPath -ChildPath "Plumbing"
    }

    # If we have a datasheet for the selected equipment, proceed; otherwise, exit
    if ( (Test-Path -Path $datasheetsFolder) -and ((Get-ChildItem -Path $datasheetsFolder -Filter "*.pdf").Count -gt 0 )) {
        # Take user input based on equipment type
        $userInput = @{specs = @(); descriptors = @() }
        $equipmentUnits = $units[$selectedEquipment]
        foreach ($unit in $equipmentUnits) {
            $inputUnit = [double] (Read-Host "Please enter the required $unit")
            while (-Not ($inputUnit -is [int] -or $inputUnit -is [double])) {
                $inputUnit = [double] (Read-Host "Invalid input. Please enter a numeric value for $unit")
            }
            $userInput.specs += $inputUnit
        }

        # Get descriptor for selected equipment
        if ($subMenu[$selectedEquipment].Count -gt 0) {
            $descriptorOption = Show-Menu -prompt "Please select an option for $selectedEquipment." -selectedMenu $subMenu[$selectedEquipment] -selectedAcronyms $subAcronyms
            $selectedDescriptor = $subMenu[$selectedEquipment][$descriptorOption - 1]
            $userInput.descriptors += $selectedDescriptor
        }

        # Get datasheets based on user input
        $matchedDatasheets = Get-Datasheets -folderPath $datasheetsFolder -userInput $userInput

        # Display matched datasheets
        if ($matchedDatasheets.Count -gt 0) {
            Write-Host "We have found the following datasheets that match your input:"
            for ($i = 0; $i -lt $matchedDatasheets.Count; $i++) {
                Write-Host "$($i + 1). $($matchedDatasheets[$i].Name)"
            }

            # Ask user to select a datasheet
            $datasheetOption = Read-Host "Please enter the option number of the datasheet you would like to copy"
            while (-Not ($datasheetOption -gt 0 -and $datasheetOption -le $matchedDatasheets.Count)) {
                $datasheetOption = Read-Host "Invalid option. Please enter a valid option number"
            }

            # Copy the selected datasheet to the destination path
            if (Test-Path -Path $destinationPath) {
                $datasheetPath = Join-Path -Path $datasheetsFolder -ChildPath $matchedDatasheets[$datasheetOption - 1].Name
                $destinationPath = Join-Path -Path $destinationPath -ChildPath $matchedDatasheets[$datasheetOption - 1].Name
                Write-Host "Copying datasheet..."
                Copy-Item -Path $datasheetPath -Destination $destinationPath -Force
                Write-Host "The selected datasheet has been copied successfully. You can find it inside the Selection folder under Mechanical or Plumbing based on the equipment type."

                # Save selected datasheet to projectInfo.json
                $projectInfo.EquipmentList += $matchedDatasheets[$datasheetOption - 1].Name
                $projectInfo | ConvertTo-Json | Set-Content "$projectPath/projectInfo.json"
            }
            else {
                Write-Host "Selection folder does not exist! Cannot copy datasheet!"
            }
        }
        else {
            Write-Host "Sorry, we don't have any datasheets that match your input. Please try again with different specifications."
            exit
        }
    }
    else {
        Write-Host "Sorry, we don't have a datasheet for the selected equipment. Please try again later."
        exit
    }
}

# If operation is none of the above, exit
else {
    Write-Host "Sorry, this operation is either invalid or not yet implemented. Please try again later."
    exit
}
