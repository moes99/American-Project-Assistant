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

$sourceFolder = $PWD.Path.Trim('"')

$managementFolder = Join-Path $PSScriptRoot "..\Management"
$targetFileJson = Get-Content -Path (Join-Path -Path $managementFolder -ChildPath "nextProjectNb.json") | ConvertFrom-Json
$targetFile = ConvertTo-Hashtable $targetFileJson

foreach ($item in $targetFile.GetEnumerator()) {
    $country = $item.Key
    $prefix = $item.Value[0]
    $nb = $item.Value[1]
    $matchingFolders = Get-ChildItem -Path $sourceFolder -Filter "$prefix*" -Directory
    $lastFolder = if ($matchingFolders.Length -gt 0) {
        $matchingFolders[0]
    }
    else {
        "N/A"
    }
    Write-Host "for $country :`n$lastFolder"
    Write-Host "---------------------------------------------------------------------------------------------------------------"
}