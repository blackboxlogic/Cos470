# Assignment 1 "Dollar Words"
Due Thursday 2019-09-12

## Assignment Goal
* Student practices using Visual Studio and c# to work with the Console, Files, strings and collections.
* Estimated Time: 60 minutes (your mileage may vary)

FYI: If this assignment doesn't interest you, you may submit any project that meets the assignment goals above. It must be your original work, done *for this class* and include a README file describing the purpose and demonstrating the input/output of your project.

## Context
"Dollar words" are words whose letters add up to 100. Letters are valued as: a=1, b=2 ... z=26. The valuation is not case sensitive. Any character which is not A-Z are valued as 0.

## Directions
Assumption: you already have your Cos470 repo checked out to your computer and Visual Studio installed.
1. Add an "Assignment1" folder to your repo
1. Create a new command line application in "Assignment1"
   1. Hint: Visual Studio -> File -> New -> Project -> "Console App (.NET Core)". You might need to download/install an SDK if that option isn't available.
1. Download [words_alpha.txt](https://github.com/dwyl/english-words/blob/master/words_alpha.txt)
1. Program your application to
   1. Read the text file
   1. Find all "Dollar words"
   1. Write the dollar words to a file "DollarWords.txt"
   1. Write aggregate information to the console (for example: what portion of words are dollar words)
1. Commit this work, and push it to github

## Reading:
* [List<T>](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8)