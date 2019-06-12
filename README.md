# Photo-Album
Technical Showcase for Lean TECHniques

This is my version of the photo album technical showcase.
When looking at the albums online, I envisioned a selection option for the user to choose a desired album (but also make it able to run for all albums if desired).

Once I saw that the source data was in JSON, all that was needed was a JSON package that could handle it appropriately (I went with Newtonsoft).
I deserialized it into a List of objects that could store each attribute seperatly and make them all easy to access.

The prompts will walk you though how to run it.  Simply enter the album you want to see the photo ids and titles for.
You may enter 999 to view all albums.
I initially had it laid out in a "Photo ID: " + id + ", Photo Title: " + title design but decided it was best to stick to formatting on example PDF.

I have used -1 as a sentinal value to exit the loop as this would not be entered as an album number on purpose.
I added validation to ensure only exisiting album numbers could be entered.

Please let me know if you have any questions!

Mikaela Stanislav
mstanislav05@gmail.com
515-418-0872
