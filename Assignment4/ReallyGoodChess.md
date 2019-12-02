# Really Good Chess
Assigned: 2019/12/03
Due: 2019/21/03

### Objective
* Practice the features of C#, and be creative, and maybe have fun?

### Context
Our chess game is *really good*, but could it be *better*?!?!

### Directions
* Fork my new chess repo [https://github.com/blackboxlogic/ReallyGoodChess](https://github.com/blackboxlogic/ReallyGoodChess) to your github account
* Make a new type of chess piece (Inherits `Piece`)
** Your piece should be not be over-powered or useless or like any other piece
** Your piece should use a [new symbol](https://unicode-table.com/en/sets/flowers-symbols/) when displayed on the board
** Add this new piece in that gap next to the kings on the starting board
* Make a new type of "smart" chess player (Inherits `Player`)
** Your player should *reliably* beat the `DumbPlayer when it plays as either black or white
* Make a new type of chess player (Implements `Player`)
** This player will allow a human player to choose moves
** User may only choose moves that are legal
** User chooses their player name

**OR**

Create an AI player who is good enough to reliably beat me.
You can use any third party API or nuget package but remember that our version chess is "really good".

**OR**

Write a function that takes an array of Player and runs a bracketed double elimination tournament. Show the winner's name at the end and the winning player's end positions for all the games they played.

### I need to
* Move to it's own repo
* change palyer to return scores for boards
* allow option to implement minimax