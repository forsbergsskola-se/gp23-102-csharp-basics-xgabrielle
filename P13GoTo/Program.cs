
int winningNumber = Random.Shared.Next(1,101);


TryAgain:
Console.WriteLine("Choose a number between 1-100");
    int userGuess = int.Parse(Console.ReadLine());


if (userGuess < winningNumber)
{
    Console.WriteLine("Higher");
    goto TryAgain;
}

if (userGuess > winningNumber)
{
    Console.WriteLine("Lower");
    goto TryAgain;
}

if (userGuess == winningNumber)
{
    Console.WriteLine("Well done, you guessed right!");
}