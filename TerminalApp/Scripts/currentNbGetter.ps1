param(
    [Parameter(Mandatory = $true)]
    [string]$searchPath,
    [Parameter(Mandatory = $true)]
    [string]$countryIndex
)

$projects = Get-ChildItem -Path $searchPath -Filter "$countryIndex.*" -Directory

$largestNumber = $projects |
ForEach-Object {
    $match = [regex]::Match($_.Name, '^\d+\.\d+\.(\d+)')
    if ($match.Success) {
        [int]$match.Groups[1].Value
    }
} |
Sort-Object -Descending |
Select-Object -First 1

return $largestNumber