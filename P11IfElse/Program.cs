/*
Console.WriteLine("What's you're age?");
int ageInput = int.Parse(Console.ReadLine());

if (ageInput <= 12)
    Console.WriteLine("You're a child");

else if (ageInput <= 18)
    Console.WriteLine("You're a teenager");

else
    Console.WriteLine("You're an adult");


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
*/

// P11_1Grades
/*
Console.WriteLine("Give me a number:");
int userInput = int.Parse(Console.ReadLine());

if (userInput >=90)
    Console.WriteLine("A");
else if (userInput >=80)
    Console.WriteLine("B");
else if (userInput >=70)
    Console.WriteLine("C");
else if (userInput >=60)
    Console.WriteLine("D");
else
    Console.WriteLine("F");
    */



// P11_2MinMax
/*
int a;
int b;
int c;

Console.WriteLine("Give me 3 numbers:");

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());

if ((a>b) && (a>c))
    Console.WriteLine($"{a} = highest number");
else if ((b>a) && (b>c))
    Console.WriteLine($"{b} = highest number");
else
    Console.WriteLine($"{c} = highest number");


if ((a<b) && (a<c))
    Console.WriteLine($"{a} = lowest number");
else if ((b<a) && (b<c))
    Console.WriteLine($"{b} = lowest number");
else
    Console.WriteLine($"{c} = lowest number");
*/

// P11_3Characters

/*
Console.WriteLine("Give me any character:");
string userInput = Console.ReadLine();
char userChar = char.Parse(userInput);
bool IsLetter = char.IsLetter(userChar);
if (IsLetter)
{
    if (userInput == ("a")|| userInput==("o") || userInput == ("u") 
        || userInput == ("e") || userInput == ("i")|| userInput ==("y"))
        Console.WriteLine("Vowel");

    else
        Console.WriteLine("Consonant");
}

else
    Console.WriteLine("Number");
*/

// P11_4Calculator
/*
int a;
char b;
int c;
Console.WriteLine("What would you like to calculate?");

int userFirstInput = int.Parse(Console.ReadLine());
char userSignInput = char.Parse(Console.ReadLine());
int userSecondInput = int.Parse(Console.ReadLine());

if (userSignInput=='+')
    Console.WriteLine(userFirstInput+userSecondInput);
else if (userSignInput=='-')
    Console.WriteLine(userFirstInput-userSecondInput);
else if (userSignInput=='*')
    Console.WriteLine(userFirstInput*userSecondInput);
else if (userSignInput=='/')
    Console.WriteLine(userFirstInput/userSecondInput);
*/

// P11_5EvenOrOdd
/*
Console.WriteLine("Write a number:");

int userInput = int.Parse(Console.ReadLine());

if (userInput % 2 == 0)
    Console.WriteLine("That's an even number");

else
    Console.WriteLine("That is an odd number");
    */