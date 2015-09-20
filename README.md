# NUSGrabberGUI
Sharing the code to solve issue's.

I have created a GUI application in C# that parses the TitleID etc. from [WiiUBrew.org Title Database](http://wiiubrew.org/wiki/Title_database) and uses the NUS grabber tool from [crediar](https://twitter.com/crediar).

His NUSGrabber console application can be found [here](http://crediar.no-ip.com/wupsite/).

Info:

What it does is just parsing the table from WiiUBrew's Wiki with the relevant data.
Data as the TitleID is retrieved and the "00050000-" of the ID gets replaced with "0005000E".

I fill the data in the Comboboxes (aka Dropdownmenu's) and the user can click on the [Download] button.
After which this application launches the NUSGrabber console with the parameters, based on the user's selection in the Comboboxes.

Screenshots:

![alt tag](http://i.imgur.com/N4Kt8en.png)

![alt tag](http://i.imgur.com/Kfmnyws.png)
