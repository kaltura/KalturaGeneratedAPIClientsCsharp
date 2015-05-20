#!/bin/bash - 
#===============================================================================
#          FILE: build.sh
#         USAGE: ./build.sh 
#   DESCRIPTION: 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: Jess Portnoy (), <jess.portnoy@kaltura.com>
#  ORGANIZATION: Kaltura, inc.
#       CREATED: 05/20/2015 06:03:52 PM IDT
#      REVISION:  ---
#===============================================================================

#set -o nounset                              # Treat unset variables as an error
sed -i "s#@YOUR_PARTNER_ID@#1931861#g" -e "s#@YOUR_USER_SECRET@#c66b9aed76e28c91455cb69fec6f2f7d#" -e "s#@YOUR_ADMIN_SECRET@#83c3d4449a3abbe92ca5966f5f010eb4#g" -e "s#@SERVICE_URL@#http://www.kaltura.com#" -i KalturaClientTester/KalturaClientTester.cs
xbuild KalturaClient.sln
cd ./KalturaClientTester/bin/Debug/ &&  mono KalturaClientTester.exe

