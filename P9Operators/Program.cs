// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Give me a number of sec.");
string userInput = Console.ReadLine();


Console.WriteLine("");
*/

// Exercise 1

/*
Console.WriteLine("Input minutes");

string minute = Console.ReadLine();
int sec = int.Parse(minute);

int result = sec * 60;
Console.WriteLine("There are " + result + " seconds in " + minute + " minutes");
*/

// Exercise 2
/*
Console.WriteLine("Write 1 number:");
string first = Console.ReadLine();

float f = float.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

float s = float.Parse(second);

float result = f / s;

Console.WriteLine(first + " divided by " + second + " = " + result);
*/

// Exercise 3
/*
Console.WriteLine("Write 1 number:");
string first = Console.ReadLine();

float f = float.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

float s = float.Parse(second);

float result = f % s;

Console.WriteLine(first + " % " + second + " = " + result);
*/

// Exercise 4

/*
Console.WriteLine("Write 1 number:");
string userInput = Console.ReadLine();

float radius = float.Parse(userInput);

float radiusX2 = radius * radius;

float f = MathF.PI;

float result = radiusX2 * f;

Console.WriteLine("Area of the circle is " + result);
*/

// Exercise 5

// Exercise 6
/*
Console.WriteLine("Write 1 number:");
string first = Console.ReadLine();

float f = float.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

float s = float.Parse(second);

float result = f * s;

Console.WriteLine(first + " multiplied by " + second + " = " + result);
*/

//Exercise 7

Console.WriteLine("Write your height in metric :");
string height = Console.ReadLine();

float h = float.Parse(height);


float heightx2 = h * h;


Console.WriteLine("Write your weight in kilos:");
string weight = Console.ReadLine();

float w = float.Parse(weight);

float result = w / heightx2;

Console.WriteLine("BMI = " + result); 