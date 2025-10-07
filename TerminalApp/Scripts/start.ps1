# Convert a PSCustomObject to a hashtable
function ConvertTo-Hashtable {
    param (
        [PSCustomObject]$inputObject
    )
    $hashtable = @{}
    foreach ($property in $inputObject.PSObject.Properties) {
        $hashtable[$property.Name] = $property.Value
    }
    return $hashtable
}

# Get project information
function Get-ProjectInfo {

    # Get project name & client name
    $projectName   = Read-Host "Enter the project name"
    $clientName    = Read-Host "Enter the client name"

    # Get project country
    $availableCountries = $menus.Countries
    # Display menu for country selection
    Write-Host "Choose the country where the project is located from the options below"
    for ($i = 0; $i -lt $availableCountries.Count; $i++) {
        Write-Host "$($i + 1). $($availableCountries[$i])"
    }
    # Check if option is valid
    $option = Read-Host "Enter option number"
    while (-Not ($option -gt 0 -and $option -le $availableCountries.Count)) {
        $option = Read-Host "Invalid option. Please enter a valid option number"
    }
    $country = $availableCountries[$option - 1]

    # Get project state, address, type, building type, scope, project director, project manager, trade developers
    $state        = Read-Host "Enter the project's state's full name"
    $address       = Read-Host "Enter the project's full address"
    $type          = Read-Host "Is this project residential or commercial?"
    $buildingType       = Read-Host "What is the building type (example: Single Family, Multi-Family, Office, Retail, Restaurant, etc.)?"
    $scope         = Read-Host "Enter the project scope (example: M, P, E, T24, Manual J, etc., or any combination)"
    $projectDirector = Read-Host "Enter the project director's name"
    $projectManager  = Read-Host "Enter the project manager's name"
    $tradeDevelopers = Read-Host "Enter the trade developers' names in following format: (Trade: Name). Make sure every pair is followed by a comma except the last one. Example: (M: John Doe), (P: Jane Smith), (E: Bob Johnson)"

    $info = @{
        ProjectName   = $projectName
        ClientName    = $clientName
        Country       = $country
        State        = $state
        Address       = $address
        Type          = $type
        BuildingType       = $buildingType
        Scope         = $scope
        ProjectDirector = $projectDirector
        ProjectManager  = $projectManager
        TradeDevelopers = $tradeDevelopers
        EquipmentList = @()
        CreatedDate   = (Get-Date).ToString("yyyy-MM-dd")
    }
    return $info
}

# Load path to important folders
$resourcesFolder = Join-Path $PSScriptRoot "..\Resources"
$scriptsFolder = Join-Path $PSScriptRoot "..\Scripts"
$managementFolder = Join-Path $PSScriptRoot "..\Management"

# Load menus, acronyms, equipment, and nextProjectNb
$acronyms = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "acronyms.json") | ConvertFrom-Json
$menus = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "menus.json") | ConvertFrom-Json
$equipment = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "equipment.json") | ConvertFrom-Json

# Project path and its leaf
$projectPath = $PWD.Path.Trim('"')
$projectLeaf = Split-Path -Path $projectPath -Leaf

# Initialize projectInfo variable
$projectInfo = @{}

# Greet user
Write-Host "Welcome! I am your project assistant. My purpose is to help you while working on a project."

# Check if user wants to create a new project or work on an existing one
if ($projectLeaf -eq "1-Projects In Hand"){
    # Greet user for new project
    Write-Host "I see you are trying to create a new project. Let's get started!"

    # Get project information from user
    Write-Host "I require some information about the project first."
    $projectInfo = Get-ProjectInfo

    # Determine the new project number
    $nextProjectNbFile = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "nextProjectNb.json") | ConvertFrom-Json
    $nextProjectNbTable = ConvertTo-Hashtable -inputObject $nextProjectNbFile
    $newProjectIndex = $nextProjectNbTable[$projectInfo.Country][0]
    $newProjectSubNb = $nextProjectNbTable[$projectInfo.Country][1]
    $newProjectNb = "$newProjectIndex.$newProjectSubNb"
    Write-Host "The new project number is $newProjectNb"
    $projectInfo["ProjectNumber"] = $newProjectNb

    # Update nextProjectNb.json file
    $nextProjectNbTable[$projectInfo.Country][1]++
    $nextProjectNbTable | ConvertTo-Json | Set-Content -Path (Join-Path -Path $managementFolder -ChildPath "nextProjectNb.json")

    # Create master folder for the new project
    $masterFolderName = "$($newProjectNb)_" + "$($projectInfo.ClientName)" + " " + "$($projectInfo.ProjectName)" + " " + "$($projectInfo.Address)" + " " + "$($projectInfo.Scope)"
    $masterFolderPath = Join-Path -Path $projectPath -ChildPath $masterFolderName
    New-Item -Path $masterFolderPath -ItemType Directory | Out-Null
    Write-Host "A new folder named '$masterFolderName' has been created for your project."

    # Update projectPath variable to point to the new project folder and change directory to it
    $projectPath = Join-Path -Path $projectPath -ChildPath $masterFolderName
    Set-Location -Path $projectPath

    # Save projectInfo to json file in the new project folder
    $projectInfo | ConvertTo-Json | Set-Content "$projectPath/projectInfo.json"
}
else{
    # Greet user for existing project
    Write-Host "I see the master folder has been already created. Let's continue!"

    # Create json file that contains project information if it doesn't exist
    if (-Not (Test-Path -Path "$projectPath/projectInfo.json")) {
        Write-Host "The project information file does not exist. Let's create it now."
        $projectInfo = Get-ProjectInfo
        $projectInfo | ConvertTo-Json | Set-Content "$projectPath/projectInfo.json"
    }
}

# Check if folder structure has already been setup
if (-Not (Test-Path -Path "$projectPath/Working Folder/MP")) {
    # Create folder structure if not already created
    Write-Host "Let's start by creating the folders for this project."
    & "$scriptsFolder/folderMaker.ps1" -projectPath $projectPath
}
else {
    Write-Host "The folder structure is already set up."
}

# Copy cad template if MP-DD.dwg does not exist
if (-Not (Test-Path -Path "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg")) {
    # Copy the appropriate CAD template
    Write-Host "Now, let's copy the appropriate CAD template to the DWGs folder."
    if ($projectInfo.Country -ne "USA"){
        Write-Host "Sorry, I don't have CAD templates for countries other than USA yet. Please copy the appropriate template manually."
    }
    else{
        if ($projectInfo.State -eq "California"){
            $cadTemplatePath = Join-Path $resourcesFolder "Templates\CA-MP-DD.dwg"
            Copy-Item -Path $cadTemplatePath -Destination "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg"
            Write-Host "The California CAD template has been copied to the DWGs folder under the name 'MP-DD.dwg'."
        }
        elseif ($projectInfo.State -eq "Florida"){
            $cadTemplatePath = Join-Path $resourcesFolder "Templates\FL-MP-DD.dwg"
            Copy-Item -Path $cadTemplatePath -Destination "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg"
            Write-Host "The Florida CAD template has been copied to the DWGs folder under the name 'MP-DD.dwg'."
        }
        else{
            Write-Host "Does this project use International or Uniform codes? (I/U)"
            $codeOption = Read-Host "Enter I for International or U for Uniform"
            while ($codeOption -ne "I" -and $codeOption -ne "U") {
                $codeOption = Read-Host "Invalid option. Please enter I for International or U for Uniform"
            }
            if ($codeOption -eq "I"){
                $cadTemplatePath = Join-Path $resourcesFolder "Templates\INT-MP-DD.dwg"
                Copy-Item -Path $cadTemplatePath -Destination "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg"
                Write-Host "The International CAD template has been copied to the DWGs folder under the name 'MP-DD.dwg'."
            }
            else{
                $cadTemplatePath = Join-Path $resourcesFolder "Templates\UNI-MP-DD.dwg"
                Copy-Item -Path $cadTemplatePath -Destination "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg"
                Write-Host "The Uniform CAD template has been copied to the DWGs folder under the name 'MP-DD.dwg'."
            }
        }
    }
}
else {
    Write-Host "A CAD template already exists in the DWGs folder."
}

# Keep on looping until user exits
$generalMenu = $menus.GeneralMenu
$option = 0
while ($option -ne $generalMenu.Count) {
    # Display menu for other operation
    Write-Host "What would you like to do? Choose from the options below."
    for ($i = 0; $i -lt $generalMenu.Count; $i++) {
        Write-Host "$($i + 1). $($generalMenu[$i])"
    }

    # Check if option is valid
    $option = Read-Host "Enter option number"
    while (-Not ($option -gt 0 -and $option -le $generalMenu.Count)) {
        $option = Read-Host "Invalid option. Please enter a valid option number"
    }

    # User has selected a valid option
    switch ($option) {
        1 {
            # Select datasheet
            $equipmentAcronyms = ConvertTo-Hashtable -inputObject $acronyms.Equipment
            $descriptors = ConvertTo-Hashtable -inputObject $equipment.Descriptors
            $descriptorsAcronyms = ConvertTo-Hashtable -inputObject $acronyms.Descriptors
            $units = ConvertTo-Hashtable -inputObject $equipment.Units
            & "$scriptsFolder/resourceManager.ps1" -projectPath $projectPath -resourcesFolder $resourcesFolder -operation "datasheet" -menu $menus.Equipment -acronyms $equipmentAcronyms -subMenu $descriptors -subAcronyms $descriptorsAcronyms -units $units
        }
        2 { 
            # Select calculation sheet
            $calculationSheetsAcronyms = ConvertTo-Hashtable -inputObject $acronyms.CalculationSheets
            & "$scriptsFolder/resourceManager.ps1" -projectPath $projectPath -resourcesFolder $resourcesFolder -operation "calculation" -menu $menus.CalculationSheets -acronyms $calculationSheetsAcronyms
        }
        3 {  
        }
        4 {
            exit 
        }
    }
}

# User decided to exit
Write-Host "Thank you for using the project assistant. Goodbye!"
