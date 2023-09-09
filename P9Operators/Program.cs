// See https://aka.ms/new-console-template for more information
// Execise 10

int TwentyFourHourSeconds = 86400;

Console.WriteLine("Give me a number of sec.");
string userInput = Console.ReadLine();


float floatInput = float.Parse(userInput);

// in total days form
float inTotal = floatInput / TwentyFourHourSeconds;



// 1 day form
int intInput = (int)floatInput;
int day = intInput / TwentyFourHourSeconds;

int oneDayHours = day * 24;

int hours = intInput / 60 / 60 - 24;

int minutes = intInput / 60 - ( hours + oneDayHours) * 60;

int seconds = intInput - (((hours + oneDayHours) * 60 * 60) + (minutes * 60));


Console.WriteLine($"{seconds} \n{minutes} \n{hours} \n{day} \n{day}.{hours}.{minutes}.{seconds} \n{inTotal}");


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

int f = int.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

int s = int.Parse(second);

int result = f / s;

Console.WriteLine(first + " divided by " + second + " = " + result);
*/

// Exercise 3
/*
Console.WriteLine("Write 1 number:");
string first = Console.ReadLine();

int f = int.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

int s = int.Parse(second);

int result = f % s;

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

int f = int.Parse(first);

Console.WriteLine("one more number:");
string second = Console.ReadLine();

int s = int.Parse(second);

int result = f * s;

Console.WriteLine(first + " multiplied by " + second + " = " + result);
*/

//Exercise 7
/*
Console.WriteLine("Write your height in meters :");
string height = Console.ReadLine();

float h = float.Parse(height);

float heightx2 = h * h;

Console.WriteLine("Write your weight in kilos:");
string weight = Console.ReadLine();

float w = float.Parse(weight);

float result = w / heightx2;

Console.WriteLine("BMI = " + result);
*/

// Exercise 8
/*
Console.WriteLine("Write 1 number:");
string UserAdjacentInput = Console.ReadLine();

float adjacent = float.Parse(UserAdjacentInput);
float adjacentX2 = adjacent * adjacent; 

Console.WriteLine("Write 1 number:");
string UserOppositeInput = Console.ReadLine();

float opposite = float.Parse(UserOppositeInput);
float oppositeX2 = opposite * opposite;
float squareIt = adjacentX2 + oppositeX2;

double sum = Math.Sqrt(squareIt);

Console.WriteLine("answer" + sum);
*/

//Exercise 9
/*
Console.WriteLine("Give an amount of seconds:");
string userInput = Console.ReadLine();

int seconds = int.Parse(userInput);

int spare = seconds % 60;

//int i = (int) seconds;
int minutes = seconds / 60;

Console.WriteLine($"{userInput} = {minutes} and {spare} seconds");
*/
