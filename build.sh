#!/bin/sh

# Fetch dependencies
cd VfioUsbClient
nuget install -OutputDirectory ../packages
cd ../VfioUsbServer
nuget install -OutputDirectory ../packages

# Build libvirt bindings
cd ..
git clone https://gitlab.com/libvirt/libvirt-csharp.git
cd libvirt-csharp/projects/MonoDevelop
xbuild /p:Configuration=Release LibvirtBindings.sln

# Build
cd ../../../
xbuild /p:Configuration=Release VfioUsbManager.sln
