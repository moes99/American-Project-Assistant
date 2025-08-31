#Project and base paths
$projectPath = $PWD.Path.Trim('"')
$basePath = "Desktop/American Project Assistant/TerminalApp/Management" #Change this when it is transferred to server

# Load global variables from JSON file
$globalVariables = Get-Content -Raw -Path "$basePath/globalVariables.json" | ConvertFrom-Json
$resourcesFolder = $globalVariables.resourcesFolderPath
$scriptsFolder = $globalVariables.scriptsFolderPath
$managementFolder = $globalVariables.managementFolderPath

# Greet user and run folderMaker.ps1 script to create folder structure
Write-Host "Welcome! I will be your project assistant.`nLet's start by creating the folders for this project."
& "$scriptsFolder/folderMaker.ps1" -projectPath $projectPath

# Ask user for operation
Write-Host "What would you like to do next?"