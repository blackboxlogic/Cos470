# Assignment 2 "Dollar Addresses"
Due Tuesday 2019-09-24

## Assignment Goals
* Student creates project that makes web calls, deserializes the response (xml or json), analyzes the data and outputs some result.
* Code must be well organized.
* Code must be configurable.
* Code must be unit tested.
* Estimated Time: 60 minutes (your mileage may vary)

FYI: If this assignment doesn't interest you, you may submit any project that meets the assignment goals above. It must be your original work, done *for this class* and include a README file describing the project and demonstrating the input/output. **Your project must be interesting.**

## Context
"Dollar addresses" are street addresses where the house number is the "cost" of the street.
"Cost" of a street is the sum of the letters in the streetName and streetSuffix (a=1, b=2 etc). Example: "71 High St"
Your goal is to output all street names in your home town (or some town in Maine if you're "from away") that have a dollar address.

## Directions
1. Add an "Assignment2" folder to your repo
1. Create a new command line application in that folder
1. Make your program
   1. Fetch all addresses in your home town from "the API"
   1. Deserialize the response
   1. Filter the addresses to only include where the house number = "cost" of the street name.
      1. Or, I don't know, do some other interesting data analysis.
   1. List the street names of those addresses to Console
1. Make your program configurable
   1. Identify any parameters that your boss is likely to change
   1. DO NOT HARD CODE those parameters, instead put them in a config file
1. Add unit tests
   1. Unit test any tricky functions that don't touch other resources (don't unit test IO operations)
1. Commit Code and some proof of the output, push it to github.

## "The API":
* [A description of the data set](https://gis.maine.gov/arcgis/rest/services/Location/Maine_E911_Addresses_Roads_PSAP/MapServer/1)
* [An Example Query](https://gis.maine.gov/arcgis/rest/services/Location/Maine_E911_Addresses_Roads_PSAP/MapServer/1/query?where=MUNICIPALITY%3D%27Limestone%27&text=&objectIds=&time=&geometry=&geometryType=esriGeometryEnvelope&inSR=&spatialRel=esriSpatialRelIntersects&relationParam=&outFields=ADDRESS_NUMBER%2CSTREETNAME%2CSUFFIX%2CMUNICIPALITY%2CLatitude%2Clongitude&returnGeometry=false&returnTrueCurves=false&maxAllowableOffset=&geometryPrecision=&outSR=&returnIdsOnly=false&returnCountOnly=false&orderByFields=address_number&groupByFieldsForStatistics=&outStatistics=&returnZ=false&returnM=false&gdbVersion=&returnDistinctValues=false&resultOffset=0&resultRecordCount=&f=html)
* Change "Format" from "HTML" to "JSON" to get just the data.
* Note: this is a government API, be nice to it.