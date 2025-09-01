#Project and base paths
$projectPath = $PWD.Path.Trim('"')

# Load path to important folders
$resourcesFolder = Join-Path $PSScriptRoot "..\Resources"
$scriptsFolder = Join-Path $PSScriptRoot "..\Scripts"
$managementFolder = Join-Path $PSScriptRoot "..\Management"

# Greet user
Write-Host "Welcome! I am your project assistant."

#Check if folder structure has already been setup
if(-Not (Test-Path -Path "$projectPath/Working Folder/MP")){
    #Create folder structure if not already created
    Write-Host "Let's start by creating the folders for this project."
    & "$scriptsFolder/folderMaker.ps1" -projectPath $projectPath
}
else {
    Write-Host "The folder structure is already set up."
}

#Check if MP-DD.dwg exists
if(-Not (Test-Path -Path "$projectPath/Working Folder/MP/DWGs/MP-DD.dwg")){
    #Copy the appropriate CAD template
    Write-Host "Now, let's copy the appropriate CAD template to the DWGs folder."
    & "$scriptsFolder/resourceManager.ps1" -projectPath $projectPath -resourcesFolder $resourcesFolder -operation "template"
}
else{
    Write-Host "A CAD template already exists in the DWGs folder."
}

<# Ask user for operation
Write-Host "What would you like to do? Choose from the options below."
$chosen=$false
while(-Not $chosen){
    Write-Host 
}#>