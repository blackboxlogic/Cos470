# Assignment 2 "Dollar Addresses"
Due Thursday 2019-09-19

## Assignment Goals
* Student creates project that makes web calls, deserializes the response (xml or json), analyzes the data and produce some result.
* Code must be well organized.
* Code must be configurable.
* Code must be unit tested.
* Estimated Time: 60 minutes (your mileage may vary)

FYI: If this assignment doesn't interest you, you may submit any project that meets the assignment goals above. It must be your original work, done *for this class* and include a README file describing the project and demonstrating the input/output. **Your project must be interesting.**

## Context
"Dollar addresses" are street addresses where the house number is 100.
Your goal is to output all street names in your home town (or some town in Maine if you're "from away") that have a dollar address.

## Directions
1. Add an "Assignment2" folder to your repo
1. Create a new command line application in that folder
1. Make your program
   1. Fetch all addresses in your home town from the API
   1. Deserialize the response
   1. Filter the addresses to only include where the house number is 100
   1. List the street names of those addresses
1. Make your program configurable
   1. Identify any parameters that your boss is likely to change
   1. DO NOT HARD CODE those parameters, instead put them in a config file
1. Add unit tests

## Hints:

#### Fetching data from an API
```
var query = HttpUtility.ParseQueryString(string.Empty);
query["weapon"] = "laser";
query["power"] = 100.ToString();
query["target"] = Enemy.Robot.ToString();

var address = @"https://www.HumanDefenceForce.com/api/fire?" + query;
using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address))
{
    var client = new HttpClient();
    var response = client.SendAsync(request).Result;
    var content = response.Content.ReadAsStringAsync().Result;
    if (!response.IsSuccessStatusCode)
    {
        throw new Exception($"{content}: {Response.StatusCode}");
    }
    return content;
}
```

#### Deserializing Json
Create classes to represent the data model



#### Getting things from config file:
Add a nuget package reference to `Microsoft.Extensions.Configuration.Json`
Add a file `appsettings.json` to your project (Make sure property 'Copy to output directory' is not 'do not copy')
```
{
  "planet": "world",
  "greeting": "hello"
}
```
Put something like this in your Main()
```
var config = new ConfigurationBuilder()
	.AddJsonFile("appsettings.json", false, true)
	.Build();

var planet = config["Planet"];
var greeting = config["greeting"];
Console.WriteLine($"{greeting} {planet}");
```

#### Adding unit tests
1. Add a "NUnit tests" project to your solution
1. Have the NUnit project reference the other project
1. Add unit tests for each function that you don't want Doug to break
1. To run your tests: Test -> Windows -> Test Explorer -> RunAll (arrow button)
1. You can debug a test by right clicking on it in the Test Explorer window and selecting debug

## Reading:
* 