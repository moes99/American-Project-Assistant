# Get current directory path and remove any quotes
param(
    [Parameter(Mandatory = $true)]
    [string]$projectPath,
    [string]$operation,
    [string]$resourcesFolder,
    [array]$menu,
    [hashtable]$acronyms
)

# Display a menu for user to choose an operation
function Show-Menu {
    param(
        [string]$prompt
    )

    Write-Host $prompt
    for ($i = 0; $i -lt $menu.Count; $i++) {
        Write-Host "$($i + 1). $($acronyms[$menu[$i]])"
    }

    $option = Read-Host "Enter option number"
    while (-Not ($option -gt 0 -and $option -le $menu.Count)) {
        $option = Read-Host "Invalid option. Please enter a valid option number"
    }

    return $option
}

# If operation is "template", ask user for state and copy the appropriate CAD template
if ($operation -eq "template") {
    # Destination and templates folder paths
    $destinationPath = Join-Path -Path $projectPath -ChildPath "Working Folder\MP\DWGs"
    $templatesFolder = Join-Path -Path $resourcesFolder -ChildPath "Templates"

    #Determine which template to copy based on user input
    $option = Show-Menu -prompt "Which type of code does this project use? Choose from the below options."

    #Point to the right template and create its path
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
