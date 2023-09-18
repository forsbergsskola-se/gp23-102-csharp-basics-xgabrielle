Console.WriteLine("Welcome to Nim");
int matches = 24;

drawAgain:
Console.WriteLine("Remove 1-3 matches");
Console.WriteLine("User");
//int draw = int.Parse(Console.ReadLine());
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

matches = matches - draw;
if (matches > 1)
{
    
    Console.WriteLine(matches);
    int aiDraw = Random.Shared.Next(1,4);
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


    
    
    