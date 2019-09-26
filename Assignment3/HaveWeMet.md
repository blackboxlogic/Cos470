# Have we met? (part 1)
Assigned: 2019
Due: 2019/10/03

### Context
* So... what can we do with location data?

### Directions
* Create and checkout a new branch "Assignment3" (to hold all work for this assignment)
* Create a .Net Core Class Library (to hold all "business logic")
  * Add classes to define a data model which is compatible with the sample JSON.
  * DO NOT add a data-layer or data-source (no way to load actual data, all data and options will be passed into your library)
  * Implement these two features:
    * *Check Alibi* A way to check where you were on a particular day
    * *Have we met?* A way to find collisions between location histories
* Create a Unit test project
  * Write tests to test each "tricky" function in the business logic
  * 
* (Suggestion) You might want to make a separate console app to work with your business logic library.
* Create a pull request from branch "Assignment3" to "Master", but don't merge it
* Code review someone else's assignment (Teacher will assign pairs)

####
Resources:
* [Distances on circles](https://stackoverflow.com/questions/1253499/simple-calculations-for-working-with-lat-lon-and-km-distance)
* [Your location data](https://takeout.google.com/settings/takeout/custom/location_history?hl=en&gl=US&expflags)
* [My location data]()
