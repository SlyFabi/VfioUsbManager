# VFIO USB Manager
Allows you to attach/detach USB Devices directly from your Windows VM with Profiles.

# Setup
## Server
First you need mono from your favorite package manager.
> pacman -S mono

If you want to run the server without root, you need to your user to the libvirt group:
> usermod -a -G libvirt [User]

Then run the server with:
> mono ./VfioUsbServer.exe [VM Name]

## Client
Simply run VfioUsbClient.exe and enter the server ip in the settings window. Now you can create profiles and attach/detach them as you wish.