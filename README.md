# Raspberry PI Remote Control
A small .NET Core WebApi that runs shell commands on the raspberry pi

## Installing .NET Core runtime on Raspberry Pi
https://github.com/dotnet/core/blob/master/samples/RaspberryPiInstructions.md

https://docs.microsoft.com/en-us/dotnet/core/linux-prerequisites?tabs=netcore2x

### Commands that might help
cat /etc/os-release

cat /proc/cpuinfo

uname -a

## Manual DEPLOYMENT
dotnet publish -r linux-arm -o ./publish && scp -r ./publish/* pi@192.168.1.245:/home/pi/WestPi.Remote
