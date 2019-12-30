On my computer, the Jester's character takes 3 spaces instead of 2, which breaks the board layout. Your screenshot shows that you didn't have this problem. (-0 points)
The human player is given board coordinates in a non-standard notation. (4,2) should be like "f5". (-2 points)
When given a high number, message has typo: "Not a vlid move number. Please try again" (-1 point)
When given a negative number: `History.Push(moves[moveIndex]);` throws "Index was outside the bounds of the array." and crashes (-4 points)
When given letters: `moveIndex = Convert.ToInt32(Console.ReadLine());` throws "Input string was not in a correct format." and crashes (-4 points)
Regarding `HumanPlayer.ChooseHumanMove()`, it would have been much cleaner to change the signature of `BasePlayer.ChooseMove()` so that you are still inheriting and overriding that function. Then you wouldn't need to do things like `if (CurrentPlayer.GetType() == typeof(BasePlayer))`, which is the whole point of inheritance. If you're writing code asking what type something is, then there is an better way. (-2 points)
Same things with `if ((piece.GetType() == typeof(Model.Pieces.Jester)) && (piece.Color == Color.Black))`, fix `BasePiece` instead of creating an exception to it.
Your `Jester` is a cool idea and the code for the piece is well written. There is a bug in `Jester`. It shouldn't be able to move to (2,0) in this picture. (-2 points)

Your `Alien` is a neat idea and well written.
Your `BetterPlayer` is very aggressive and thoroughly destroys the `BasePlayer`. The code is simple and appears to function as designed.

Your `Snowman` piece is simple and well coded.
Your "fix" to the render class doesn't work on my computer:
Your unit tests are well done. We already know of two bugs in the pawn. Would have been nice to write tests for those and have them failing. (-1 point)
* Pawn gets to last rank by capturing, it doesn't get promoted
* Pawn can't do the "in passing" move

* Thanks for fixing the end-game issue.
* `Frog` is neat and well done.
* Your smart player is effective and thoroughly destroys the `BasePlayer`.
* instead of `if (p.GetType().Name == "Pawn")` consider `if (p is Pieces.Pawn)`

Your unit tests are well done. We already know of two bugs in the pawn. Would have been nice to write tests for those and have them failing. (-1 point)
* Pawn gets to last rank by capturing, it doesn't get promoted
* Pawn can't do the "in passing" move

The star piece is fun and is well written.
The player lacks "usability". (-10 points)
You did a good job validating user input!

I like the Squart (i guess you'd need dice to do it in real life).
human player: Use input is hard. if User types in -1 for their move, you crash hard (-4 points). And 'White' isn't a valid color? (-1 point).

Scissors is a neat piece. There is a bug in your scissors. you said they can always move forward straight or at at an angle. But "forward" for you pieces is not up/down the board, it is to the right. (-2 points)
I don't get the red background on my computer.
human player: Use input is hard. if User types in 0 for their move, you crash hard (-4 points).
Yes, something is fairly wrong with castling. (-0 points because you did other parts)

Both `BombAssassin` and `Murderer` are well designed and implemented

PieceyMcPiece is fun. You're player ties for smartest AI.
reminder that `if (p.GetType() == typeof(King))` could just be `if (p is King)`

smart player
snowman
There's a bug in your smartPlayer when options[0] is a capture. (-5 points)

In `Checkers` you repeated yourself (typed the same thing a bunch of times) which would have been a good opportunity to use a loop. (-0 points)
The human player lacks any "usability", since they can't know what they are doing. (-10 points)
when I type "abc" for the move number, it hard crashes your program. (-4 points)
There is a bug in `Checkers` where you can capture your own piece. (-2 points)

You made `Trident` but I don't see the second half of the assignment (-50 points)
Didn't make a pull request (-2 points)
