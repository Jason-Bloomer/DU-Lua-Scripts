# TYR Mining Unit Control Uplink

This script will provide a simple but elegant report for Mining Units in Dual Universe, using a single Programming Board and Screen. It updates in real-time, provided nothing breaks. 

Originally written for TYR Expedition Group, I have been given permission to open source the code and provide it free to anyone who wishes to use it or improve upon it.

## Usage

You will need:<br>
<ul>
	<li>1x Screen Element of any size</li>
	<li>1x Programming Board</li>
	<li>1x Databank</li>
	<li>1x Detection Zone (Optional, but at least a size-M is recommended)</li>
	<li>At least one Mining Unit. Supports up to seven. (1-7)</li>
</ul><br>
<br>
Installation steps:
<ol>
	<li>Place your elements. They can be moved later.</li>
	<li>Copy the contents of the screen file and paste it into your Screen element. Make sure the screen is on.</li>
	<li>Copy the contents of the PB file, and in-game, right click your Programming Board, and select "Advanced > Paste Lua Configuration from Clipboard".</li>
	<li>Link order is important here. Link the PB to the screen first. Second, link the PB to the databank. Then, link PB to all mining units you want the script to monitor.</li>
	<li>Link your detection zone to the PB if you want the script to run when someone is nearby.</li>
</ol><br>
<br>

#### If at any point the script stops updating, simply restart the programming board.<br>
Sometimes, it gets stuck. This can happen when the system hits a lagspike, or something. Oof :(
<br><br>

## TODO

I had big ambitions for this project. Hopefully it will be revived at some point after NQ decides on a wipe.

Features I would like to add:
<ul>
	<li>The "Uplink" portion (Allow the data to be transmitted and recieved via transmitter, ships could collect the data)</li>
	<li>An interface for viewing calibrations, who did them, and the results.</li>
	<li>Better visuals, enhanced animations.</li>
	<li>Something that helps you find and search for harvest rocks from calibrations. Possibly AR?</li>
	<li>And... you know, stuff.</li>
</ul>
