// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Give me a number of sec.");
string userInput = Console.ReadLine();


Console.WriteLine("");
*/
/* Exercise 1
Console.WriteLine("Input minutes");

string minute = Console.ReadLine();
int sec = int.Parse(minute);

int result = sec * 60;
Console.WriteLine("There are " + result + " seconds in " + minute + " minutes");
*/

// Exercise 2

Console.WriteLine("Write 1 number:");
string first = Console.ReadLine();

float f = float.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

float s = float.Parse(second);

float result = f / s;

Console.WriteLine(first + " divided by " + second + " = " + result);
