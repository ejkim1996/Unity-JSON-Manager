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