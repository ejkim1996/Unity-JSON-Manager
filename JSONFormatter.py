import json
from tkinter import Tk
from tkinter.filedialog import askopenfilename

# Python script that allows user to select JSON file using TKinter and format it properly.

root = Tk()
filename = askopenfilename()
root.destroy() # Close the window

read = open(filename, 'r')
parsed = json.load(read)
write = open(filename, 'w')

newstr = json.dumps(parsed, indent = 3, sort_keys =True)     

write.write(newstr) # Overwrite the old unformatted json file

read.close()
write.close()
