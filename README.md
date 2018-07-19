# Unity JSON Manager for Translations
## Project Specifications
**Goal**

To create a tool that simplifies and stardardizes the creation and management of JSON files used for texts/translations in Unity.

**Structure**
- JSON Manager
    - A prefab that has an Editor Script Component that contains the following:
        - a text field to input the name of JSON file to create.
        - a button to create JSON file.
- Translatable Object
    - A regular C# script to be added to Text GameObjects with text to be stored in an existing JSON file.
        - Contains a text field for the ID (string or number most probably) of the text we want to store. (We might want to make this read-only after the data is created within the JSON file)
        - Also contains a dropdown menu of existing JSON files for grouping and a button to update the JSON file.

**Functions**
- JSON Manager
    - On create button pressed
        - Takes the name inputted in the text field and creates a JSON file in Assets/StreamingAssets
- Translatable Object
    - On update button pressed
        - Takes information from the Text Component in the GameObject and adds to or updates the corresponding JSON file.
    - On Play/Start
        - Takes the ID and group name and dynamically updates the text of the Text Component


-------------------------------------------------------------
## Usage Instructions

**Create a JSON File**

1) Add the "JSON Manager" prefab into your project hierarchy.
2) Enter the filename to be used for the JSON file (either with or without the .json extension) in the editor window.
<img src="jsonscript.png" alt="JSONscript example" width="400px"/>
3) Click the "Build JSON File" button, which will create the file in the StreamingAssets folder.

**Add Values to a JSON File**

1) Attach the "Translatable" script component to the Text object you wish to edit. You should see this window in the inspector:
<img src="basetranslatable.png" alt="Blank translatable" width="400px"/>
2) In the "ID" field, enter the string ID you want to associate with the text value.
3) Enter the value you would like to add in the "Text" field, or leave it blank to use the current text value of the attached object.
<img src="basenew.png" alt="Add new info" width="400px"/>
4) Select the JSON file you wish to edit from the dropdown menu.
<img src="newdropdown.png" alt="New info dropdown" width="400px"/>
5) Click the "Update JSON file with text component" button.

**Update Values in a JSON File**

1) In the "ID" field of the Translatable component, enter the string ID associated with the value you wish to update.
2) In the "Text" field, enter the new text to save in the JSON.
<img src="baseexisting.png" alt="Edit existing info" width="400px"/>
3) Select the JSON file you wish to edit from the dropdown menu.
<img src="existingdropdown.png" alt="Existing info dropdown" width="400px"/>
4) Click the "Update JSON File with Text Component" button.
