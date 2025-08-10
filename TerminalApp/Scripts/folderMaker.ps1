# Get path directly from terminal
$basePath = $PWD.Path.Trim('"')

# Function to test and create folder
function New-Folder{
    param([string]$Parent, [string]$Child)
    $fullPath = Join-Path -Path $Parent -ChildPath $Child
    if (-Not (Test-Path -Path $fullPath)) {
        New-Item -ItemType Directory -Path $fullPath | Out-Null
        Write-Host "Created folder: $fullPath"
    } else {
        Write-Host "Folder already exists: $fullPath"
    }
    return $fullPath
}

# Create parent folder of name Working Folder
$workingFolderPath = New-Folder -Parent $basePath -Child "Working Folder"

if (-not [string]::IsNullOrEmpty($workingFolderPath)) {
    # Create child folder of name Arch inside "Working Folder"
    New-Folder -Parent $workingFolderPath -Child "Arch"

    # Create child folder of name MP inside "Working Folder"
    $mpPath = New-Folder -Parent $workingFolderPath -Child "MP"

    if (-not [string]::IsNullOrEmpty($mpPath)) {
        # Child folders of MP
        $childFoldersToCreate = @(
            "DWGs",
            "PDFs",
            "Selection",
            "Calculations"
        )

        # Loop through each folder and create it
        foreach ($folder in $childFoldersToCreate) {
            New-Folder -Parent $mpPath -Child $folder
        }
        
        # Create child folders of names "Mechanical" and "Plumbing" inside "Selection"
        $selectionPath = Join-Path -Path $mpPath -ChildPath "Selection"
        if (Test-Path -Path $selectionPath) {
            New-Folder -Parent $selectionPath -Child "Mechanical"
            New-Folder -Parent $selectionPath -Child "Plumbing"
        }
    } else {
        Write-Host "MP folder path is invalid. Stopping child folder creation."
    }

    
} else {
    Write-Host "Working Folder path is invalid. Stopping folder creation."
}
