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

{
    // go back to here
    int matchesToDraw = matches;
    go:
    if (matchesToDraw > 0)
    {
        Console.Write("|");
        matchesToDraw--;
        goto go;
    }
    Console.WriteLine(matches);
}

if (matches > 0)
{
    
    int aiDraw = Random.Shared.Next(1,4);
    Console.WriteLine("Ai");
    Console.WriteLine($"The AI draws {aiDraw} matches.");
    matches -= aiDraw;
    {
        // go back to here
        int matchesToDraw = matches;
        go:
        if (matchesToDraw > 0)
        {
            Console.Write("|");
            matchesToDraw--;
            goto go;
        }
        Console.WriteLine(matches);
    }
    
    if (matches > 0)
    {
        goto drawAgain;
    }

    Console.WriteLine("ai loser");

}
else
{
    Console.WriteLine("user loser");
}


    
    
    