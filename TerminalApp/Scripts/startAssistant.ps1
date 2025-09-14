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

# Project and base paths
$projectPath = $PWD.Path.Trim('"')

# Greet user
Write-Host "Welcome! I am your project assistant. First I need to gather some information about your project."

# Create json file that contains project information if it doesn't exist
if (-Not (Test-Path -Path "$projectPath/projectInfo.json")) {
    $projectInfo = @{
        ProjectName   = Read-Host "Enter the project name"
        ClientName    = Read-Host "Enter the client name"
        Type          = Read-Host "Is this project residential or commercial?"
        Scope         = Read-Host "Enter the project scope (example: M, P, E, T24, or any combination)"
        CodeType      = ""
        EquipmentList = @()
        CreatedDate   = (Get-Date).ToString("yyyy-MM-dd")
    }
    $projectInfo | ConvertTo-Json | Set-Content "$projectPath/projectInfo.json"
}

# Load path to important folders
$resourcesFolder = Join-Path $PSScriptRoot "..\Resources"
$scriptsFolder = Join-Path $PSScriptRoot "..\Scripts"
$managementFolder = Join-Path $PSScriptRoot "..\Management"

# Load menus, acronyms, & equipment
$acronyms = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "acronyms.json") | ConvertFrom-Json
$menus = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "menus.json") | ConvertFrom-Json
$equipment = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "equipment.json") | ConvertFrom-Json

# Check if folder structure has already been setup
if (-Not (Test-Path -Path "$projectPath/Working Folder/MP")) {
    # Create folder structure if not already created
    Write-Host "Let's start by creating the folders for this project."
    & "$scriptsFolder/folderMaker.ps1" -projectPath $projectPath
}
else {
    Write-Host "The folder structure is already set up."
}

# Check if MP-DD.dwg exists
if (-Not (Test-Path -Path "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg")) {
    # Copy the appropriate CAD template
    Write-Host "Now, let's copy the appropriate CAD template to the DWGs folder."
    $codeTypeAcronyms = ConvertTo-Hashtable -inputObject $acronyms.CodeTypes
    & "$scriptsFolder/resourceManager.ps1" -projectPath $projectPath -resourcesFolder $resourcesFolder -operation "template" -menu $menus.CodeTypes -acronyms $codeTypeAcronyms
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
