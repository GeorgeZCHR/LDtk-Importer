check the "appVersion" inside the "__header__" in the .LDtk file to be compatible with the LDtkImporter.

I made the LDtkImporter from an example of .LDtk with appVersion 1.5.3 and of course i read the LDtk DOCS (JSON 1.5.3).
It's just an importer not a renderer.

I will name the LDtkImporter version 1.5.3 for obvious reasons.

Important :
If the setting Multi-Worlds Support is enabled in the LDtk then you will get the levels from the List<LDtkWorld> inside the LDtkFile.
If not then you will get the levels from the LDtkFile.
