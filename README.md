Copy of Winch Mod Template below, disregard


# WinchModTemplate
A template Dredge mod for use with the Winch mod loader

### Prerequisites
- An IDE that supports .NET, like Visual Studio ([community version available here](http://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community))
- Dredge Mod Manager (get it from the [Dredge Mods](https://dredgemods.com) website)
- Winch installed in the mod manager
- A GitHub account (required for using the template and releasing your mod to the public)

### Editing the mod_meta file

The `mod_meta.json` file looks something like this:
```
{
	"Name": "Winch Mod Template",
	"ModGUID": "YourName.WinchModTemplate",
	"Version": "0.0.1",
	"ModAssembly": "WinchModTemplate.dll",
	"MinWinchVersion": "0.6.1",
	"Entrypoint": "WinchModTemplate.Loader/Initialize"
}
```
You will want to change most of these fields

- `Name`: This is the human readable name of your mod. They will see this name in the mod manager and on the website.
- `ModGUID`: This is the unique identifier for your mod. To prevent overlaps, you should make this `[YourName].[ModName]`. For example, `xen.CosmicHorrorFishingBuddies`. If you ran the auto-renaming script this should already be set to an appropriate unique id.
- `ModAssembly`: The main `.dll` file for your mod. This should have been changed along with all other references to `WinchModTemplate` when running the auto-renaming script.
- `MinWinchVersion`: Set this to be the current Winch version you're using. If you update your mod to make use of new Winch features make sure this is up-to-date.
- `EntryPoint`: This is the class and method that is initially called to start your mod. Normally you can just leave this as its default value after running the auto-renaming script.
