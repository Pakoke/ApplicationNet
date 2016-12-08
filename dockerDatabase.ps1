#Name of the docker that you want to detect and reinstall
$nameDocker="";
#absolute dir of the dacpac which have to load inside of the SQL database.
$dirDacpacToLoad
#password of the sql server express
$passwordSQL="qwerty_1234567890"
#See if docker is installed
Try
{
    Get-Command docker
}
Catch
{
    Write-Error "Docker is not installed in windows"
    exit
}

#See if sql server docker is installed. If not continue, if it's installed ,remove it and running again.
$dockerid = docker ps -a --filter "ancestor=microsoft*"
