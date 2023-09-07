// See https://aka.ms/new-console-template for more information

bool child;
bool teenager;
bool adult;

Console.WriteLine("What's you're age?");
int ageInput = int.Parse(Console.ReadLine());

if (ageInput <= 12)
{
    
    Console.WriteLine("You're a child");
}

else if (ageInput >= 13 && ageInput <= 18)
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

if (secondNumberInput > ageInput)
{
    Console.WriteLine($"The maximum is: {secondNumberInput}");
}

else
{
    Console.WriteLine($"The maximum number is: {ageInput}");
}
