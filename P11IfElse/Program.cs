// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's you're age?");
int ageInput = int.Parse(Console.ReadLine());

if (ageInput <= 12)
{
    Console.WriteLine("You're a child");
}

else if (ageInput <= 18)
{
    Console.WriteLine("You're a teenager");
}

else
{
    Console.WriteLine("You're an adult");
}

// Second round
Console.WriteLine("Give me another number: ");
int secondNumberInput = int.Parse(Console.ReadLine());

int highestNum;

if (secondNumberInput > ageInput)
    highestNum = secondNumberInput;

else
    highestNum = ageInput;


Console.WriteLine($"The maximum number is: {highestNum}");

if (highestNum % 2 == 0)
    Console.WriteLine("Your number is even");

else
    Console.WriteLine("Your number is odd");



