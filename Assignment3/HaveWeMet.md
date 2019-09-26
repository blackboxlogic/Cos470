# Have we met? (part 1)
Assigned: 2019
Due: 2019/10/03

### Context
* So... what can we do with location data? Write a *library* to do some analysis.
* *Library* means this code can't run on its own. Next assignment we'll make something to use it.
* "But parts of this assignment seem vague!" Yup.

### Directions
* Create and checkout a new branch "Assignment3" (to hold all work for this assignment)
* Create a `.Net Core Class Library` (to hold all "business logic")
  * Add classes to define a data model which is compatible with the sample JSON (lat, lon, time, other stuff?).
  * DO NOT add a data-layer or data-source (no way to load actual data, all data and options will be passed into your library)
  * Implement these two features:
    * *Check Alibi* A way to check where you were on a particular day
    * *Have we met?* A way to find collisions between location histories
    * Or... I don't know, do something else interesting like... figure out where the person lives. Or... guess what bank they use.
* Create a Unit test project
  * Write tests to test each "tricky" function in the business logic
  * Probably use some [sample data](https://github.com/blackboxlogic/Cos470/blob/master/Assignment3/Location%20History%20Very%20Short.json) for this
  * Make sure your tests pass... Otherwise why did you make them?
* (Suggestion) You might want to make a separate console app to play with your business logic library. Not part of the grade.
* Create a pull request from branch "Assignment3" to "Master", but *don't merge it.*

### Read:
* [code review stuff](https://github.com/features/code-review/)
* [code review things](https://mtlynch.io/human-code-reviews-1/)

#### I googled some things for you:
* [Your google location data](https://takeout.google.com/settings/takeout/custom/location_history?hl=en&gl=US&expflags)
* [Google Location schema](https://gifguide2code.com/2018/02/12/json-how-to-read-your-google-location-data/)
* [Your Facebook Location data](https://www.facebook.com/help/212802592074644)
* [Your Apple location data](https://www.apple.com/newsroom/2011/04/27Apple-Q-A-on-Location-Data/)
* [Distances on circles](https://stackoverflow.com/questions/1253499/simple-calculations-for-working-with-lat-lon-and-km-distance)
* [Working with Unix Time](https://stackoverflow.com/questions/17632584/how-to-get-the-unix-timestamp-in-c-sharp)
