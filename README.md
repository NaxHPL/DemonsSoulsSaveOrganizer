# Demon's Souls Save Organizer
The Demon's Souls Save Organizer is a tool used for creating and loading savestates for Demon's Souls running on emulator.

## Requirements
+ [Microsoft .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)

## Download
[Latest Release](https://github.com/NaxHPL/DemonsSoulsSaveOrganizer/releases)

## Getting Started
1. Click the top "Browse" button and choose the directory that contains the save data files for Demon's Souls. It will be named either "BLUS30443DEMONSS005" or "BLES00932DEMONSS005" depending on your game's version and can be found in "...\RPCS3\dev_hdd0\home\00000001\savedata\".

2. Create an empty folder somewhere which will be used to store your profiles and savestates.

3. Click the second "Browse" button and navigate to the newly created folder.

4. Click on "New Profile", enter a profile name, and click OK.

5. You are now ready to start importing and loading savestates.

## Importing Savestates
1. Before importing, make sure you have at least one profile set up. If you don't, you will be prompted to create one.

2. Make sure you are not in-game (no character should be loaded). The game should be in the main menu or closed.

3. Click the "Import Savestate" button to import the current save.

4. Right click on the savestate in the list and choose "Rename" (or press F2) to rename it to whatever you like.

## Loading Savestates
1. Make sure you are not in-game (no character should be loaded). The game should be in the main menu or closed.

2. Select the profile which contains the savestate you wish to load.

3. Select the desired savestate and click "Load Savestate". This will overwrite the game's current save data with your savestate.

    > Warning: The characters shown in the load character menu may not reflect the characters that you just loaded. This is because the game only updates that info on start-up. The desired character will still be loaded assuming there is a character in that save slot to select. If you try to load a character from a slot that the savestate has no data for, you'll likely run into strange behaviour or the emulator will crash. Restarting the game will cause the load character menu to reflect any changes.

4. Load the desired character.

## Credits
[LowLevelHooking](https://github.com/jnm2/LowLevelHooking) by Joseph N. Musser II
