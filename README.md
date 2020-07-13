# VFIO USB Manager
Allows you to attach/detach USB Devices directly from your Windows VM with Profiles.

# Setup
## Building
You need mono for building this project.

On Linux run:
> xbuild /p:Configuration=Release VfioUsbManager.sln 

On Windows open VfioUsbManager.sln in Visual Studio and build it from there.

Binaries are in VfioUsbManager/VfioUsbClient/bin/Release/ and VfioUsbManager/VfioUsbServer/bin/Release/ respectively.

## Server
First you need mono from your favorite package manager.
> pacman -S mono

If you want to run the server without root, you need to your user to the libvirt group:
> usermod -a -G libvirt [User]

Then run the server with:
> mono ./VfioUsbServer.exe [VM Name]

If you want to use the display switching feature, you´ll need ddcutil:
> pacman -S ddcutil

ddcutil requires root permissions to access the i2c bus, so you need to run the server as root or add a udev rule.

## Client
Simply run VfioUsbClient.exe and enter the server ip in the settings window. Now you can create profiles and attach/detach them as you wish.
