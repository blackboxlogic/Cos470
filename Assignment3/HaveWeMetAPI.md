# Have we met? (part 3)
Assigned: 2019/10/22
Due: 2019/10/31

## Assignment Goals
* Use C#
* Student creates an API that accepts requests containing data, does some analysis, and responds with a result.
* Code must be well organized (Business logic should be in a separate library).
* Requests must use appropriate HTTP verbs (get, put, post, delete).
* Responses must use appropriate HTTP response codes, including for error responses.
* Code must be configurable.
* Estimated Time: 60 minutes (your mileage may vary)

FYI: If this assignment doesn't interest you, you may submit any project that meets the assignment goals above. It must be your original work, done *for this class* and include a README file describing the project and demonstrating the input/output. **Your project must be interesting.**

### Assignment
* Create a new project to your solution: `ASP.NET Core Web Application`, when prompted select `API`
* Add a reference to your business logic class library
* Add a data file to your project, to be used as a data source (make sure it is copied to the output directory during build)
  * you can use one of the location [history files](https://github.com/blackboxlogic/Cos470/tree/master/Assignment3) from my repo if you don't have one
* Add an appropriately named Controller
  * Add an action for each public function in your business logic
  * Add a constructor that loads data from the data file into memory
* Add a file that shows a sample request and a response from your API using Postman

### Hints
* If loading data from file takes a long time, you probably should load data into your controller once in the controller's constructor, not every time it receives a request.
* Probably check out the [demo project](https://github.com/blackboxlogic/Cos470/tree/master/Notes/WebThing) and use it as an example?
* Yes, email me when you get stuck.