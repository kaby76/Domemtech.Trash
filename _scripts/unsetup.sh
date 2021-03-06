#!/bin/bash

directories=`find . -maxdepth 1 -type d -name "tr*"`
for i in $directories
do
	if [ "$i" == "." ]
	then
		continue
	fi
	cd $i
	csproj=`find . -maxdepth 1 -name '*.csproj'`
	if [[ "$csproj" == "" ]]
	then
		cd ..
		continue
	fi
	if [[ ! -f "$i.csproj" ]]
	then
		cd ..
		continue
	fi
	echo $i
	tool=${i##*/}
	dotnet nuget remove source nuget-$tool > /dev/null 2>&1
	cd ..
done

dotnet nuget remove source nuget-AntlrJson > /dev/null 2>&1
dotnet nuget remove source nuget-Docs > /dev/null 2>&1
dotnet nuget list source
