# Get current directory path and remove any quotes
$basePath = $PWD.Path.Trim('"')

# Set paths
$destinationPath = Join-Path -Path $basePath -ChildPath "Working Folder\MP\DWGs"
$sourcePath = "C:\Users\user\Desktop\MP-DD.dwg"
$targetFile = "MP-DD.dwg"
$targetFullPath = Join-Path -Path $destinationPath -ChildPath $targetFile

# Check if destination folder exists
Write-Host "Checking if DWGs folder exists..."
if (Test-Path -Path $destinationPath) {
    Write-Host "DWGs folder exists! Checking if $targetFile exists..."

    # Check if file already exists
    if (-Not (Test-Path -Path $targetFullPath)) {
        Write-Host "Copying MP-DD.dwg..."
        Copy-Item -Path $sourcePath -Destination $destinationPath -Force
        Write-Host "$targetFile has been copied successfully."
    } else {
        Write-Host "$targetFile already exists! Copying is stopped!"
    }
} else {
    Write-Host "DWGs folder does not exist! Cannot copy $targetFile."
}
