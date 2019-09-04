# Assignment 1 "Dollar Words"
Due Thursday 2019-09-12

## Assignment Goals
* Student practices using Visual Studio and c# to work with the Console, Files, strings and Generic Collections.
* Code should be well organized.
* Estimated Time: 60 minutes (your mileage may vary)

FYI: If this assignment doesn't interest you, you may submit any project that meets the assignment goals above. It must be your original work, done *for this class* and include a README file describing the project and demonstrating the input/output. **Your project must be interesting.**

## Context
"Dollar words" are words whose letters add up to 100 cents. Letters are valued as: a=1 cent, b=2 cents ... z=26 cents. The valuation is not case sensitive. Any character which is not A-Z is free.

## Directions
Assumption: you already have your Cos470 repo checked out to your computer and Visual Studio installed.
1. Add an "Assignment1" folder to your repo
1. Create a new command line application in "Assignment1"
   1. Hint: Visual Studio -> File -> New -> Project -> "Console App (.NET Core)". You might need to download/install an SDK if that option isn't available.
1. Download [words.txt](https://github.com/dwyl/english-words/blob/master/words.txt)
1. Program your application to
   1. Read the text file
      1. Hint: The `File` class, `using System.IO`;
      1. Hint: If you use a file `Stream`, remember to `Dispose()` it.
   1. Find all "Dollar words" as described in "Context" above
      1. Hint: business logic code should be cleanly separated from user interface code
   1. Write the dollar words to a file like: "DollarWords.txt"
   1. Write some aggregate information to the console, *for example*:
      1. what portion of words are dollar words
      1. how long it took
      1. what was the longest/shortest dollar word
      1. what is the most expensive word
1. Save a screenshot of the console output into the project directory
1. Commit this work (with an *informative commit message*), and push it to github

## Reading:
* [Dictionary<K, V>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)