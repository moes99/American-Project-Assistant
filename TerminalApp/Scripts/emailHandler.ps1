# Connect to Outlook
$outlook = New-Object -ComObject Outlook.Application
$namespace = $outlook.GetNamespace("MAPI")

# Get the Inbox folder
$inbox = $namespace.GetDefaultFolder([Microsoft.Office.Interop.Outlook.OlDefaultFolders]::olFolderInbox)

# Show the first 10 emails
$messages = $inbox.Items | Sort-Object -Property ReceivedTime -Descending
$messages = $messages | Select-Object -First 10

foreach ($mail in $messages) {
    Write-Host "From: $($mail.SenderName)"
    Write-Host "Subject: $($mail.Subject)"
    Write-Host "Received: $($mail.ReceivedTime)"
    Write-Host "-----------------------------------"
}
