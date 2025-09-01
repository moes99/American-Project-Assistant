# Get current directory path and remove any quotes
param(
    [Parameter(Mandatory=$true)]
    [string]$projectPath,
    [string]$operation,
    [string]$resourcesFolder
)

# Display a menu for user to choose an operation
function Show-Menu{
    param(
        [string]$prompt,
        [array]$options
    )

    Write-Host $prompt
    for ($i = 0; $i -lt $options.Count; $i++) {
        Write-Host "$($i + 1). $($options[$i])"
    }

    $option = Read-Host "Enter option number"
    while (-Not ($option -gt 0 -and $option -le $options.Count)) {
        $option = Read-Host "Invalid option. Please enter a valid option number"
    }

    return $option
}

# If operation is "template", ask user for state and copy the appropriate CAD template
if ($operation -eq "template"){
    # Destination and templates folder paths
    $destinationPath = Join-Path -Path $projectPath -ChildPath "Working Folder\MP\DWGs"
    $templatesFolder = Join-Path -Path $resourcesFolder -ChildPath "Templates"

    #Determine which template to copy based on user input
    $options = @("California's", "Florida's", "International", "Uniform")
    $option = Show-Menu -prompt "Which type of code does this project use? Choose from the below options." -options $options

    #Point to the right template and create its path
    $selectedTemplate = ""
    switch ($option) {
        1 { $selectedTemplate = "CA" }
        2 { $selectedTemplate = "FL" }
        3 { $selectedTemplate = "INT" }
        4 { $selectedTemplate = "UNI" }
    }
    $selectedTemplate = $selectedTemplate + "-MP-DD.dwg"
    $selectedTemplatePath = Join-Path -Path $templatesFolder -ChildPath $selectedTemplate

    # Check if destination folder exists
    Write-Host "Checking if DWGs folder exists..."
    if (Test-Path -Path $destinationPath) {
        Write-Host "DWGs folder exists! Checking if a file by the name of MP-DD.dwg exists..."
        # Check if file already exists
        if (-Not (Test-Path -Path $"$destinationPath/MP-DD.dwg")) {
            Write-Host "Copying template..."
            Copy-Item -Path $selectedTemplatePath -Destination "$destinationPath/MP-DD.dwg" -Force
            Write-Host "The selected template has been copied successfully. You can find it inside the DWGs folder under the name MP-DD.dwg.`nDon't forget to rename the codes as per the state's code!"
        } else {
            Write-Host "MP-DD.dwg already exists! Cannot copy template."
        }
    } else {
        Write-Host "DWGs folder does not exist! Cannot copy template!"
    }
}
