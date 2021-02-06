# Virt-A-Mate New Plugin Template

This guide assumes you are somewhat familiar with a Linux terminal.

The template consist of:

- a .csproj file
- a .cslist file (which is used to load the plugin in VaM)
- an src/ dir and template .cs files for the plugin code
- a template meta.json file

It is accompanied by a new plugin project setup script, and a plugin resource var packaging script (replacing the VaM package creator).

## Requirements

- [Ubuntu on WSL](https://ubuntu.com/wsl)
- [Visual Studio Community 2019](https://visualstudio.microsoft.com/)
- [.NET 4.6.1 Developer Pack](https://www.microsoft.com/en-us/download/details.aspx?id=49978)
- [Virt-A-Mate](https://www.patreon.com/meshedvr/posts)

## Usage

First, clone (or download and unzip) this repository.

Create a dir with your creator name under the `Scripts` dir. You should have:

    VaM/Custom/Scripts/CreatorName

Copy the `NewPlugin` dir as well as the scripts `setup.sh` and `package.sh` from this repository under your creator name's dir.

Rename the `NewPlugin` dir to how you want your plugin to be named. Let's call it `MyPlugin` from now on.

Run the setup script from Ubuntu/WSL terminal. It substitutes your creator name and plugin name in the project files.

    cd <path to VaM>/Custom/Scripts/CreatorName
    ./setup.sh MyPlugin

The `<path to VaM>` is most likely something like `/mnt/<drive letter>/VaM`.

Finally, open the .csproj file in **Visual Studio** - and you're good to go.

## Multiple plugins setup

In Visual Studio, select the solution (the topmost item) in the Solution Explorer, then go to **File -> Save MyPlugin.sln As...** and name it e.g. `Plugins.sln`. Save it into your creator dir, **above** the plugin's dir. This solution will be shared by each of your plugins, making all projects easily available in the same Visual Studio window.

 You should have this dir tree:

    <VaM dir>\
        ↳ Custom\
            ↳ Scripts\
                ↳ CreatorName\
                    ↳ Plugins.sln
                    ↳ MyPlugin\
                        ↳ MyPlugin.csproj
                          ...

For a new (second) plugin, make a new copy of the `NewPlugin` under your creator dir, rename it and run the setup script as above. In Visual Studio, add the new plugin's .csproj file to the solution from **File -> Add -> Existing Project...**

## Packaging a new release version

While you can use VaM's package creator, the included `package.sh` script hides the source files (under src/), leaving only the .cslist selectable in-game.

If you need to package files other than the .cslist and src/, feel free to customize the `package.sh` on a project by project basis.

Finally, customize each project's `meta.json` to have the correct license info, description info, promotional link, file listing etc. for the plugin.

## Additional recommended tools

- JetBrains DotPeek or similar - for browsing decompiled VaM code
- CodeMaid extension for Visual Studio - keep your code style consistent and clean
- [vam-dev-tools](https://github.com/acidbubbles/vam-devtools) by acidbubbles

## Got questions?

Head to the `#scripting` channel in the official Virt-A-Mate Discord.
