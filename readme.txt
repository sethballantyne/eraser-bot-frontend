Eraser Bot Frontend v1.3 Source Code

--------------------------------------------------------------------------------------------------------------
Whats new in v1.3:
+ The map selection GUI has changed slightly. Checkboxes are now used within the tree view to allow
  users to select multiple maps at once; this design rendered the "add all" button obsolete, so it
  was removed.

+ Tooltips were added to explain what various aspects of the GUI do.

+ EBF will now attempt to automatically detect Eraser bot when setting the path for Quake II.

+ Updated the URL in the about box to point to the github page.

+ EBF now attempts to filter out weapon skins so they're not displayed in the list of available
  skins for any given model.

+ Fixed a bug where changing the paths for Quake II and Eraser caused an exception to be thrown.
------------------------------------------------------------------------------------------------------------


The code builds in VC# 2008 and uses .NET 2.0. EBF is free software, released under the MIT license. 

The latest, usable version of the software lives in the "builds" directory; along with the frontend, 
it includes a zip of the eraser bot itself and the kw skin pack, if needed. Without the skin pack installed, 
the bots in team-based games won't be appear as they should; females appear as males, yada yada.

Both eraser bot and the kw skin pack are not mine. Just want to make that clear.

To rebuild from source code, you'll need the IrrlichLime assembly and Irrlicht itself; you'll find them
in the either a zipped build or in the repo's bin directory.

Screenshots are in the wiki.

Comments, suggestions, questions or bugs send to <seth.ballantyne@gmail.com>

Have fun!

- Seth.
