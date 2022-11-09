# Dynamic Ship License Plate

### Installation

Copy the content of renderscript.txt into the screen you wish to use to display the license plate.
You may either use a standalone programming board, or a control seat to set the input to the script.

To use a Programming Board: Paste PB.txt into a Programming Board as a config, and link it to the screen.
Any time the construct is compactified, the ID is regenerated, and the script input will need to be reset.
For this reason it may be preferable to use your control seat.

To use your Control Seat: Link the seat to the screen, edit the seat's Lua with CTRL+L, click Unit on the left, and then click the onStart filter.
Paste this line into the very bottom of the onStart filter's code;

[screenslot].setScriptInput(construct.getId())

where [screenslot] is replaced with the slot corresponding to the screen you linked earlier.

### Configuration

The colors and images are all customizable. Check the first couple lines of code.
To change the planet name and image displayed, simply change the "bgplanet" variable.
The values of this variable correspond to the entries in atlas.json.
For example, a value of 1 displays Madis, 2 displays Alioth, and 3 for Thades.