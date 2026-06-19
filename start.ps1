# Stopp eventuelle kjørende instanser
Get-Process MyCvWebApp -ErrorAction SilentlyContinue | Stop-Process -Force

# Start applikasjonen i bakgrunnen
$job = Start-Job -ScriptBlock { dotnet run --launch-profile MyCvWebApp }
Start-Sleep -Seconds 3

# Åpne nettleseren
$browser = Start-Process "http://localhost:5000/Home/Interests" -PassThru

Write-Host "Applikasjonen kjører! Lukk nettleservinduet for å stoppe." -ForegroundColor Green
Write-Host "Eller trykk Ctrl+C her i terminalen." -ForegroundColor Yellow

# Vent til nettleseren lukkes
Wait-Process -Id $browser.Id -ErrorAction SilentlyContinue

# Stopp applikasjonen når nettleseren lukkes
Write-Host "Nettleser lukket. Stopper applikasjonen..." -ForegroundColor Red
Get-Process MyCvWebApp -ErrorAction SilentlyContinue | Stop-Process -Force
Stop-Job -Job $job -ErrorAction SilentlyContinue
Remove-Job -Job $job -ErrorAction SilentlyContinue

Write-Host "Applikasjonen stoppet." -ForegroundColor Red
