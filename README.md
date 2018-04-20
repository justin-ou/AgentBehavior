# Project Template for Unity
This document describes a pre-determined list of file hierarchy which should be used for Unity projects at Viacom NEXT.
The specified setup should apply to most Unity projects but exceptions may occur. Variable folders are listed below in the **[Folder hierarchy](#FolderHierarchy)** section.

This template does not contain a Unity project and hence, is not specific to a version of Unity.

__Read up on the [Viacom NEXT Documentation](https://github.com/UntitledScience/ViacomNextDocumentation/wiki) if you have not done so.__

#### Quick Links
- [How to use?](#HowToUse)
- [Folder hierarchy](#FolderHierarchy)

## <a name="HowToUse"></a> How to use?
Select a Unity version and setup the Unity project. 

> If you don't know how to do that, go home

Or [start here](https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/setting-game).

#### To use:
1. Clone this repository.
2. You should see the **Assets** folder, **.gitattributes** and **.gitignore** files.
3. Copy all the files into the root folder of your Unity project.
4. If you're working in teams, setup the Git repo for your project.
5. Add and push the new files to your existing repo.

Go to the next section to learn more about each folder.

## <a name="FolderHierarchy"></a> Folder Hierarchy
These folders contain the commonly used assets in Unity. Objects in folders should follow the same naming convention and be categorized into subfolders with the same functionalities. Some of these folders have specific functions and rules.

:arrow_down_small: Denotes optional folders. 

| Folder | Description |
| :----- | :---------- |
| \_AssetTools | Contains a list of asset store tools or libraries. Check the [Viacom NEXT Documentation](https://github.com/UntitledScience/ViacomNextDocumentation/wiki) for steps on adding in new tools to the project. |
| \_Sandbox | Sandbox or testing files may be placed here before adding them to the project. Each person may have one folder for testing in the sandbox. |
| Animation | Animations and animator controllers may be added here. These should be categorized into subfolders. |
| Audio | :arrow_down_small: Required if the default Unity audio is used. |
| Editor | Place editor scripts here. This is a [special folder](https://docs.unity3d.com/Manual/SpecialFolders.html) in Unity. |
| Fonts | Place fonts here. |
| Lighting | :arrow_down_small: Required if baked lighting is used. Add lighting data to this folder. |
| Materials | Contains a list of generic materials and its associated textures. Materials should be categorized where possible and it should have its own corresponding __Texture__ folder. |
| Models | Contains a list of models and its corresponding materials/textures folder. Check the [Viacom NEXT Documentation](https://github.com/UntitledScience/ViacomNextDocumentation/wiki) for steps on adding models to the project. |
| Physics | :arrow_down_small: Required if physics materials are used. |
| Plugins | Place required plugins here. This is a [special folder](https://docs.unity3d.com/Manual/SpecialFolders.html) in Unity. |
| Prefabs | Place prefabs here. Prefabs should be categorized into its functionalities where possible. |
| Resources | This folder should only be used when required to load objects in runtime. Objects in the folder should be categorized into its functionalities where possible. This is a [special folder](https://docs.unity3d.com/Manual/SpecialFolders.html) in Unity. |
| Scenes | Place scenes here. |
| Scripts | Place scripts here. Scripts should be categorized into its functionalities where possible. |
| Shaders | Place shaders here. Shader variants may be added for preloading shaders. |
| Sprites | Place sprites and 2D UI elements here. Sprites should be categorized into its functionalities where possible. |
| StreamingAssets| :arrow_down_small: Required if streaming assets such as FMOD or videos are used. This is a [special folder](https://docs.unity3d.com/Manual/SpecialFolders.html) in Unity. |
