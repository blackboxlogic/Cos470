# Midterm Exam 2019/10/24
The midterm exam will be held in class on Thursday 2019/10/24. You will not be allowed to use any reference while taking the exam. Bring a pen. You can leave class when you're done.

If you think the answer is different than you think I think it is, make a note why you think I think you're wrong and why you think you think you're right.

### Reference vs Value types 
Write an R or V to indicate if these `Type`s are *Reference* types or *Value* types :
  * int
  * int[]
  * string
  * bool
  * Cat
  * Dictionary<int>

### Linq
Write one English sentence for each, what do these `linq` statements do?
```c#
students.Count(s => s.Grade > 70);
```


```c#
students.Select(s => s.Name).ToArray();
```


```c#
students.OrderByDescending(s => s.Grade).Take(5).Min(s => s.Age);
```


```c#
students.GroupBy(s => s.Gender).OrderByDescending(g => g.Average(s => s.Grade)).First().Key;
```


### Classes from JSON
Design c# classes to form a *data model* which fits the structure of this json:
Reminder: This is what a class looks like:
```c#
public class Cat
{
	public string Name;
	public int AttackPoints;
	public Dog[] Targets;
}
```
```json
{
    "chemicals": [
        {
            "name": "Ground Black Pepper",
            "safetyDataSheet": "http://archpdfs.lps.org/Chemicals/Black_pepper.pdf",
            "LD50": 200,
            "hazards": [
                {
                    "condition": "eyes",
                    "response": "rinse immediately"
                }, {
                    "condition": "spilled",
                    "response": "vacuum or sweep"
                },
            ]
        }, {
            "name": "Vinegar",
            "safetyDataSheet": "http://archpdfs.lps.org/Chemicals/Vinegar.pdf",
            "LD50": 3310,
            "hazards": [
                {
                    "condition": "ingested",
                    "response": "do not give baking soda"
                }
            ]
        }
    ]
}

































```
### URL Parts
Identify the parts of this URL. Assume that the webserver is configured in the conventional way
* Circle each individual *parameter* key-value pair
* Draw a Box around the *domain* (including the sub-domain and top-level domain)
* ~~Strike through~~ the path to the *controller* (including the controller)
* Underline the *action*
* Draw a happy cat sitting on top of the *protocol*


```
https://bb.courses.maine.edu/webapps/blackboard/execute/modulepage/view?course_id=_119158_1&cmp_tab_id=_260715_1&editMode=true&mode=cpview
```


### IDisposable
If you are instantiating something which implements the `IDisposable` interface, you should probably wrap it in a __________________ statement to make sure that it gets ______________ when you're done with it.

### Draw lines connection the HTTP response code to the basic meaning
```
2xx			The client messed up
3xx			Everything is Fine
4xx			Sure, but it's over there
5xx			The server messed up
```

### Code Review
Study this code sample from "your coworker" (line numbers are on the left):
```c#
public static class Math
{
0	private static double standardDeviation;
1	public static double CalculateStandardDeviation(int[] values)
2	{
3		var sum = 0;
4		int total = 0;
5
6		for (int i = 0; i <= values.Length; i++)
7		{
8			sum = sum + values[i];
9		}
10
11		var max = sum / values.length;
12		// This is the deviation sum.
13		int deviationSum = 0;
14
15		foreach (var value in values)
16		{
17			deviationSum = deviationSum + (int)Math.Abs(value - max);
18		}
19
20		standardDeviation = deviationSum / values.length;
21		Console.WriteLine("The standard deviation is: " + standardDeviation);
22
23		return standardDeviation;
24	}
}
```
Given the above code sample, for each of these problems: write a line number where the problem occurs, why it is wrong and suggest how they can improve it.
Hint: Yes, it has each of these issues. You only need to reference one example of the problem.
* uninformative or misleading names


* inappropriate scope


* unused things


* comments that don't add any value


* integer division


* division by 0


* index out of bounds


* manual re-implementation of functionality which is in the system libraries


* "magic" (hard-coded) numbers or strings


* inconsistent code style


* User Interface code mixed with Business Logic code


* using the wrong type


* casting (to try to fix the problem caused by using the wrong type)


* "tricky" code without a unit test


* any other sins? (Extra credit, because maybe I missed something)


### Gramma
Gramma just sent me this email. Please compose a short response using at least these words:
[Web browser, request, parameters, URL, network, server, model, view, controller, response, headers, body]
```
From: Ruth ****** <******@gmail.com>
Subject: Re: Checking In
To: Alex Hennings <alex.hennings@maine.edu>
Content-Type: text/plain; charset="UTF-8"

Grandson Alex:  Thanks for your reply and info re preferred mailing address - duly noted (look for mail from me).

Re "building Web Sites", can you explain in terminology I may understand what is a website and how does it work?

Am glad the teaching is working out for YOU - continue to be pondering new material; your students are depending on YOU!!   Hugs, Gma


















```

### Git
Write a short description of what the `.gitignore` file is for and why someone would choose to use it.





