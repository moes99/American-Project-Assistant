$CutoffDate = (Get-Date).AddMonths(-6)

Get-ChildItem -Path $PWD -Directory | Where-Object {
    # 1. First, ensure the name starts with the version pattern
    $_.Name -match '^\d+\.\d+\.\d+' -and 
    ($_.LastWriteTime -le $CutoffDate) -and 
    # 2. Clean the name to just 'X.X.X' before checking the range
    (($cleanVersion = [version]($_.Name -replace '^(\d+\.\d+\.\d+).*', '$1')) -ge [version]"2.2.0" -and $cleanVersion -le [version]"2.2.1800")
} | Sort-Object { [version]($_.Name -replace '^(\d+\.\d+\.\d+).*', '$1') } | Out-File "$(Split-Path -Path $PWD -Leaf).txt"



