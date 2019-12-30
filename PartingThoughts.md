# Parting Thoughts

Class,

I hope you found Cos470 a valuable use of your time and money. I enjoyed working with each of you and I wish you success in your endeavors.

### Privacy
You may want to review/delete things posted publicly in your github for your privacy. I'm thinking about the survey at the beginning of the semester, any location data files you may have uploaded, or the issues I added which might have grades.

### Final Project
Final projects were good. The two best AI chess players took the most valuable piece that they could.
New piece types:
* Jester: takes short moves on angles and can make a second move if it didn't take anything
* Alien: can make short moves on rook directions, and can jump friendly pieces.
* Snowman: can go to any spot in a diamond shape around itself (always landing on the same color square)
* Frog: like a checkers piece, captures by jumping over something on the angle. Can only go "forward", which switches once it reaches the other side of the board.
* Star: can move 2 spaces on any diagonal (jumping to that spot)
* The Marquis: imagine a bishop, but the direction is the not-quite-diagonal direction of a knight.
* Squart: Moves like a king and can also jump/capture to a single random square on the board.
* Scissors: captures like a pawn, can move one square forward, can swap position with any friendly neighboring piece
* BombAssassin: can only move by capturing any FRIENDLY pieces. Can explode and destroy itself and all neighboring pieces
* PieceyMcPiece: Each turn, it randomly chooses to act as a pawn, bishop, rook or knight.
* Snowman & Explode: in the author's own words "snow man is a nice guy, but when he is forced to capture a piece by the player, he becomes heartbroken and explodes from guilt" (the explosion happens on the next turn)
* Checkers: Can move on a diagonal 1 spot away, or can jump over that spot and capture the piece it jumped.

### Final Exams
Final exam grades ranged from 63% to 100%. The most common mistake was fixing the O(N^2) problem. *This is important for you to be able to do*, and it will bite you in the butt.
```c#
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
// Changes to:
public Dog GetFirstDogWithACatsName(Dog[] dogs, Cat[] cats)
{
	// Create an efficient index:
	var catNames = cats.ToDictionary(c => c.Name); // Or a hashSet<string>. This is O(N) to build this.

	foreach (Dog dog in dogs) // This is O(N)
	{
		if (catNames.ContainsKey(dog.name))
		{
			return dog;
		}
	}
	// or just:
	// return dogs.First(d -> catNames.ContainsKey(d.name));
}
```

### Other Stuff
Please feel free to contact me for professional advice. Or for professional networking. Or if you're looking for a job.

Remember that address thing I was working on? I've finished developing it and [the proposal](https://wiki.openstreetmap.org/wiki/Import/Maine_E911_Addresses) is being picked apart by smart people that I will never meet. Feel free to check it out, and add your criticism to the pile.

Best wishes,
-Alex
