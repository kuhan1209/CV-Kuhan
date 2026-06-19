# Stopp applikasjonen
Get-Process MyCvWebApp -ErrorAction SilentlyContinue | Stop-Process -Force
Write-Host "Applikasjonen stoppet." -ForegroundColor Red
