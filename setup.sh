#!/bin/bash
creator_name=${PWD##*/}
plugin_name=${1/\//}

usage()
{
  echo "Usage: ./setup.sh <PluginDir>"
  echo "e.g.   ./setup.sh MyPlugin"
  exit 1
}

[ -z "$plugin_name" ] && usage
ls $plugin_name 1> /dev/null || usage

cd $plugin_name
sed -i "s/<CreatorName>/$creator_name/g" meta.json
sed -i "s/<CreatorName>/$creator_name/g" LICENSE
sed -i "s/<NewPlugin>/$plugin_name/g" meta.json
sed -i "s/NewPlugin/$plugin_name/g" NewPlugin.csproj
mv NewPlugin.csproj $plugin_name.csproj
mv NewPlugin.cslist $plugin_name.cslist
sed -i "s/NewPlugin/$plugin_name/g" src/Script.cs
sed -i "s/NewPlugin/$plugin_name/g" src/Utils/Log.cs
sed -i "s/NewPlugin/$plugin_name/g" README.md
cd ..

echo "Setup done for new plugin $plugin_name by $creator_name."
