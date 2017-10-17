
# DEPLOY
dotnet publish -r linux-arm -o ./publish && scp -r ./publish/* pi@192.168.1.245:/home/pi/WestPi.Remote