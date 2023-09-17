Console.WriteLine("Welcome to Nim");
int matches = 24;

drawAgain:
Console.WriteLine("Remove 1-3 matches");
Console.WriteLine("User");
int draw = int.Parse(Console.ReadLine());
if (draw > 3)
{
    Console.WriteLine("Don't do that, Choose 1-3 please");
    goto drawAgain;
}

matches = matches - draw;
if (matches > 0)
{
    
    Console.WriteLine(matches);
    int aiDraw = Random.Shared.Next(1,4);
    Console.WriteLine("Ai");
    Console.WriteLine(aiDraw);
    Console.WriteLine(matches-aiDraw);
    matches -= aiDraw;
    
    if (matches > 0)
    {
        goto drawAgain;
    }

    Console.WriteLine("artificial user loser");

}
else
{
    Console.WriteLine("user loser");
}


    
    
    