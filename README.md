# UnitSelector
Basis for selecting working units within a winform application

The purpose of this project is to Make a winforms object that can be added to another winforms solution to enable the user to select which units they are currently working with.

An example would be an application where the user wants to calculate the weight of a liquid in a box.  They know the dimensions of the box in centimeters, and the density of the fluid in lbm/in^3.
They are able to open the UnitSelector window and set their perferences for Length, Density, and Mass.  The result is shown in their selection of mass unit ( slugs, for some reason).

This will allow the user to dynamically alter the inputs and display of results of their program with a guaranteed consistent unit set.

This program uses UnitsNet for the back end units control.

