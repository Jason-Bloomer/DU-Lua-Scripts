# DU Image To Lua-string Converter

## Renderscript

NOTE: A small portion of the lower part of the image (5 to 8%) will be obstructed or may not be able to fit into the character requirements. Please take this into account when selecting your images.

Use of the included VB.NET program is not required, so long as you are able to convert an image to the proper string format which you can supply the renderscript.
Simply paste the contents of renderscript.txt into an ingame Screen element of any size, and paste the string for the image you have converted, into the empty double-quotes on line 12. You should be assigning the 'is' variable to the string.

## Image Converter

If you do not trust my precompiled VB.net program, you can look at the source code and compile your own if you so desire.
Following the simple rules above however should be easy enough, if you'd like to create your own conversion script.

To use the Image Converter;
	<ol>
	<li>Launch the program, and click Browse.</li>
	<li>Select the image you would like to convert, in the popup window.</li>
	<li>Select any changes to the images orientation, if any.</li>
	<li>Click Convert button, and wait for the progress bar to show green.</li>
	<li>Copy all text from the textbox on the right with ctrl+a and ctrl+c, and paste the string into the 'is' variable on line 12.</li>
	</ol>
That's it!

Depending on the size of the image, and the string that was pasted in, you may have to delete a few characters from the end of the string, so that it all fits into the 50,000 character limit.

Other than that, simply click "apply", and give the screen about 30 seconds to render the image.

## Technical

The strings themselves must follow two simple rules;<ol>
	<li>All ASCII character values must be greater than 33 and less than 126</li>
	<li>Do not use ASCII values 34 and 92</li>
	</ol>
In effect we have 91 possible values with which we can represent the intensity of a color.<br>
Typical images represent colors with values in range of 0 to 255, so we can divide 91 by 255, which gives us roughly 0.356.<br>
We use this number as a multiplier to the color values in the image, to get them to fall within acceptable character ranges.<br>
On the renderscript end we then multiply them back (by 2.8) to "restore" the color. This results in more color degradation when color values are closer to a median value (128) rather than outlying values, which helps to preserve contrast.<br>
Obviously this process is not lossless, but it does work fairly well.<br>

## Disclaimer

I take no responsibility for the content you put into screens with this tool. Use it appropriately. Note that NovaQuark has a standard submittal process for using actual image files in-game, and that all images are subject to NovaQuark's EULA and Terms of Service. Any content which violates these terms is subject to punishment at NovaQuark's discretion. My advance appologies to NQ if/when this concept is used in any nefarious manner, but if I didn't do it, someone else would!
