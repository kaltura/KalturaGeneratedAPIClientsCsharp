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
cd ./KalturaClientTester/bin/Debug/ &&  mono KalturaClientTester.exe

