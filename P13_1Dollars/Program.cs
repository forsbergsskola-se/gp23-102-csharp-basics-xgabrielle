int matches = 5;// if there is 1 dollar to be drawn then true. If there is 0 dollars to be drawn: false

// go back to here
go:
if (matches>0)
{
    Console.Write("|");
    matches--;
    goto go;
}

/*
Console.WriteLine("Welcome to Nim!");
//string match = (Convert.ToChar(124)).ToString();
char character = '|';
Console.WriteLine("|||||||||||||||||||||||| (24)");
int matches = 24; // 24 -> 21

Console.WriteLine("\nHow many matches do you want to draw?");
int userMatches = int.Parse(Console.ReadLine()); // 3
matches = matches - userMatches;

// print ai draws one match#
// reduce matches by 1
// print how many is left

Console.WriteLine("Draw matches here later: "+matches);
*/
/*
 *
 *
 * welcome to nim
 * there's 24 matches
 * how many do you want to draw?
 * > 3
 * 21
 * ai draws 1
 * 20
 * how many do you want to draw?
 * > 19
 * 1
 * ai draws 1
 * 0
 * You Win.
 */







