#!/bin/sh

SCRIPTFILE=$0

#Get the absolute path to the containing folder
PROJECTFOLDER=${SCRIPTFILE%/*}

cd ${PROJECTFOLDER}

pwd

mono /Applications/Visual\ Studio.app/Contents/Resources/lib/monodevelop/bin/vstool.exe setup pack ./TestAddin/bin/Release//net472/TestAddin.dll
