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

#Project and base paths
$projectPath = $PWD.Path.Trim('"')

# Load path to important folders
$resourcesFolder = Join-Path $PSScriptRoot "..\Resources"
$scriptsFolder = Join-Path $PSScriptRoot "..\Scripts"
$managementFolder = Join-Path $PSScriptRoot "..\Management"

# Load menus & acronyms
$acronyms = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "acronyms.json") | ConvertFrom-Json
$menus = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "menus.json") | ConvertFrom-Json

# Greet user
Write-Host "Welcome! I am your project assistant."

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
    $option -= 1
    switch ($option) {
        1 {  
        }
        2 {  
        }
        3 {  
        }
        4 {
            exit 
        }
        Default {
        }
    }

}

# User decided to exit
Write-Host "Thank you for using the project assistant. Goodbye!"
