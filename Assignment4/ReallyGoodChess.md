# Really Good Chess
Assigned: 2019/12/03
Due: 2019/12/12

### Objective
* Practice the features of C#, and be creative, and maybe do something that interests you?

### Context
Our chess game is *really good*, but could it be *really really good*?
Don't like all this chess stuff? Shoot me an email with a different project idea.

### To Start
* Fork my *new* chess repo from here: [https://github.com/blackboxlogic/ReallyGoodChess](https://github.com/blackboxlogic/ReallyGoodChess) to your github account, then git-clone that to your computer
* "But Alex, the pieces are just rectangles!" - After running, click on the top left of your console -> Properties -> Font -> use `MS Gothic`, and increase the font size

### Part 1 (50 points)
* Make a new type of chess piece (Inherits `BasePiece`)
  * Your piece should be not be over-powered or useless or like any other piece
  * Your piece should use a [different symbol](https://unicode-table.com/en) when displayed on the board
  * Add this new piece in that gap next to the kings on the starting board

Some inspiration:
* Odd movement patterns
* Piece can move to any empty space on the board, pieces next to this piece can't move
* Piece can act like any piece that is adjacent to it
* Each time piece moves, it transforms into a different piece type (including its symbol)
* Piece can move to any empty square, and this piece cannot be captured, but you've lost if this is your only piece
* When the piece captures, it explodes and everything near it (including itself) is removed from the board
* Or, like, something else? I don't know, ask a 5 year old, they might have some *1337* ideas

### Part 2 (50 points)
Pick **one** of the following:

Make a new type of "smart" chess player (Inherits `BasePlayer`).
Your player should *reliably* beat the `BasePlayer` when it plays as either black or white.
You can use any third party API or nuget package but remember that our version of chess is *special*.

**OR**

* Make a new type of "human" chess player (Inherits `BasePlayer`)
  * This player will allow a human player to choose moves
  * User chooses their player name
  * User may only choose moves that are legal

**OR**

Write a function that takes an array of `Player` and runs a chess tournament.
Show progress and statistics about tournament.

**OR**

Fix the bug: when a pawn reaches the 8th rank by capturing an opponent, the pawn doesn't promote (it stays a pawn).
AND
Implement [castling](https://en.wikipedia.org/wiki/Castling): If the king hasn't moved, and the rook hasn't moved, and there are no pieces in between them, the king moves two toward the rook and the rook jumps to the other side of the king.
AND
Implement the pawn's move [En Passant](https://en.wikipedia.org/wiki/En_passant): If an opponent's pawn has just (very last move) jumped two forward, one of your pawns can capture it as if it only moved one forward.

**OR**

Write unit tests for the pieces

**OR**

Write an API around the game, OR OMG, make it a website! Now that I think of it, it wouldn't be too hard?

**OR**

Do something else novel

### To Finish
* Add something to the repo describing what you did and demonstrating (screenshots?) the results
* Commit and push it to your github
* Make a pull request to my github
* Profit