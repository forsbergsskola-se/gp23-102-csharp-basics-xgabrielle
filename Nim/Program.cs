Console.WriteLine("Welcome to Nim");
int matches = 24;
int aiDraw = Random.Shared.Next(1,4);

drawAgain:
Console.WriteLine("||||||||||||||||||||||||");
Console.WriteLine("Remove 1-3 matches");
Console.WriteLine("User");
string matchVisual = "|";
if (!int.TryParse(Console.ReadLine(), out int draw))
{
    Console.WriteLine("You can't do that, choose 1-3 please");
    goto drawAgain;
}

if (draw > 3 ||(draw <=0))
{
    Console.WriteLine("Don't do that, choose 1-3 please");
    goto drawAgain;
}



if (matches == 3)
    aiDraw = 2;


if (matches == 2)
    aiDraw = 1;

matches = matches - draw;
if (matches > 1)
{
    
    Console.WriteLine(matches);
    
    Console.WriteLine("Ai");
    Console.WriteLine(aiDraw);
    Console.WriteLine(matches-aiDraw);
    matches -= aiDraw;
    
    
    if (matches > 1)
    {
        goto drawAgain;
    }

    Console.WriteLine("user loser");

}

else
{
    Console.WriteLine("artificial user loser");
}


    
    
    