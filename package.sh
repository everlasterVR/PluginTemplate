#!/bin/bash
creator_name=${PWD##*/}
plugin_name=${1/\//}
package_version=$2
plugin_version=$3

usage()
{
  echo "Usage: ./package.sh <PluginDir> <VarPackageVersion> <PluginVersion>"
  echo "e.g.   ./package.sh MyPlugin 1 1.0.0"
  exit 1
}

[ -z "$plugin_name" ] && usage
ls $plugin_name 1> /dev/null || usage
[ -z "$package_version" ] && usage
[ -z "$plugin_version" ] && usage

# Setup archive contents
resource_dir=publish/Custom/Scripts/$creator_name/$resource_name
mkdir -p $resource_dir
cp $plugin_name/*.cslist $resource_dir/
cp -r $plugin_name/src $resource_dir/
cp $plugin_name/LICENSE $resource_dir/src/

# Additional packaging
# add plugin specific additional package contents here, toggle line comments as needed

# Update version info in meta.json
cp $plugin_name/meta.json publish/
sed -i "s/<Version>/$plugin_version/g" publish/meta.json
sed -i "s/<Version>/$plugin_version/g" publish/src/Script.cs

# hide .cs files (plugin is loaded with .cslist)
for file in $(find $resource_dir -type f -name "*.cs"); do
  touch $file.hide
done

# Zip files to .var and cleanup
cd publish
package="$creator_name.$plugin_name.$package_version.var"
zip -r $package *
cd ..
mkdir -p ../../../AddonPackages/Self
mv publish/$package ../../../AddonPackages/Self
rm -rf publish

echo "Package $package created with version $plugin_version and moved to AddonPackages\Self."
