# Demon's Souls Save Organizer
The Demon's Souls Save Organizer is a tool used for creating and loading savestates for Demon's Souls running on emulator.

## Functionality
<p>
    <img src="https://github.com/NaxHPL/DemonsSoulsSaveOrganizer/blob/master/Images/Features.png"/>
</p>

1. The folder containing the Demon's Souls save data. This can be set via the Browse button.

2. The folder which all the profiles and savestates will be saved to. This can be set via the Browse button.

3. The profiles toolbar allows you add, delete, and rename profiles.

4. A list of profiles. Clicking on one will update the savestates list on the right.

5. The savestates toolbar provides the various savestate actions.

    **Import:** Creates a savestate of the current save data. Then, adds it to the savestates list for the selected profile.  
    **Load:** Copies the selected savestate data over the game's current save data.  
    **Replace:** Imports a new savestate and replaces the selected savestate with the new one.  
    **Sort:** Provides options to sort savestates alphabetically or by creation date.  
    **Edit:** The pencil icon allows you to rename a savestate.
    
6. A list of savestates for the selected profile.

7. Opens a context menu to view settings, an about page, or a help link. In the settings, you can configure global hotkeys.

## Requirements
+ [Microsoft .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)

## Download
[Latest Release](https://github.com/NaxHPL/DemonsSoulsSaveOrganizer/releases)

## Getting Started
1. Click the top "Browse" button and choose the directory that contains the save data files for Demon's Souls. It will be named either "BLUS30443DEMONSS005" or "BLES00932DEMONSS005" depending on your game's version and can be found in "...\RPCS3\dev_hdd0\home\00000001\savedata\".

2. Create an empty folder somewhere which will be used to store your profiles and savestates.

3. Click the second "Browse" button and navigate to the newly created folder.

4. Click the plus button under Profiles, enter a profile name, and click OK.

5. You are now ready to start importing and loading savestates.

## Importing Savestates
1. Before importing, make sure you have at least one profile set up. If you don't, you will be prompted to create one.

2. Make sure you are not in-game (no character should be loaded). The game should be in the main menu or closed.

3. Click the "Import" button to import the current save.

4. Click the far right pencil icon to rename it to whatever you like. Alternatively, right click on the savestate and choose "Rename" or press F2.

## Loading Savestates
1. Make sure you are not in-game (no character should be loaded). The game should be in the main menu or closed.

2. Select the profile which contains the savestate you wish to load.

3. Select the desired savestate and click "Load". This will overwrite the game's current save data with your savestate.

    > **Warning:** The characters shown in the load character menu may not reflect the characters that you just loaded. This is because the game only updates that info on start-up. The desired character will still be loaded assuming there is a character in that save slot to select. If you try to load a character from a slot that the savestate has no data for, you'll likely run into strange behaviour or the emulator will crash. Restarting the game will cause the load character menu to reflect any changes.

4. Load the desired character in the game.

## Credits
[LowLevelHooking](https://github.com/jnm2/LowLevelHooking) by Joseph N. Musser II
