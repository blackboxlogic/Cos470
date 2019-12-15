# Final Exam 2019/12/17 (4:15pm-6:15pm)
The final exam will be held in class on Tuesday 2019/12/17. You will not be allowed to use any reference while taking the exam. Bring a pen.
### Ternary Statements (2 points)
```
int i = 3;
i += i < 5 ? 2 : 3;
// What is the value of `i`? _______
i += i < 5 ? 4 : 6;
// What is the value of `i`? _______
```

### Thread Safety (10 points)
Consider this code that your co-worker wrote:
```
class Program
{
	static void Main(string[] args)
	{
		Parallel.For(0, 10000, i => new House(i % 3, i % 4));
		Console.WriteLine(House.HousesBuilt);
	}
}

class House
{
	int Beds;
	int Baths;
	static int HousesBuilt;

	public House(int beds, int baths)
	{
		Beds = beds;
		Baths = baths;
		// Some time-consuming operation goes here (I don't know, maybe a database call).
		HousesBuilt = HousesBuilt + 1;
	}
}
```
Building a house involves some time-consuming operation and your co-worker saves time by making many of them *in parallel*. But, after making 10,000 houses, the console output shows that it only made 9,665 houses. Show how you would fix the to **make it thread-safe** (outputting 10,000) without removing the multi-threading.
```














```

### Efficient Algorithms (10 points)
Your co-worker wrote this code and there are a *lot* of dogs and cats. It runs *really* slow. Re-write it (fix this so it is *better* than `O(n^2)`).
```
public Dog GetFirstDogWithACatsName(Dog[] dogs, Cat[] cats)
{
	foreach (Cat cat in cats)
	{
		foreach (Dog dog in dogs)
		{
			if (dog.name == cat.name)
			{
				return dog;
			}
		}
	}
}




















```

### Vocab match (1 point per match)
Write the number of the definition next to the matching word.
Not all words and definitions have a match, *if they don't match, don't match them*.

# A declarative markup language used which simplifies the creation of a UI for a .NET desktop app.
# A generic data structure which stores key-value-pairs and has efficient O(1) lookup operations.
# A type of function which calls itself.
# A Cross-platform, open-source development platform supported by Microsoft.
# A keyword which prevents two threads from executing in a code block at the same time.
# A keyword which modifies things so they belong to the type itself, *not to an instance* of the type.

* xaml
* .net Framework
* winforms
* .net Core
* HashSet<T>
* static
* readonly
* yield
* break
* .net Standard
* Dictionary<T>
* lock
* Contains()

### Write a Function (10 points)
Write a function which takes a string and returns how many "condescending" letters are in the string. (g, j, q, p, and y).
It could be used like this
`int condescending = CountCondescendingLetters("Ping pong? Yes please!"); // Should be 4`
```


















```

### Convince Me
Convince me you know what these words mean. You could give a reason you would use one, explain what they do, or gives examples.
* Solution File (3 points)
```



```
* Project References (3 points)
```



```
* Nuget Package (3 points)
```



```