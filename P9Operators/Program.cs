
// Execise 10
/*
int TwentyFourHourSeconds = 86400;

Console.WriteLine("Give me a number of sec.");
float userInput = float.Parse(Console.ReadLine());

// in total days form
float inTotal = userInput / TwentyFourHourSeconds;

// days, hour, min & sec
int intInput = (int)userInput;

int day = intInput / TwentyFourHourSeconds;
int oneDayHours = day * 24;
int hours = intInput / 60 / 60 - 24;
int minutes = intInput / 60 - ( hours + oneDayHours) * 60;
int seconds = intInput - (((hours + oneDayHours) * 60 * 60) + (minutes * 60));

Console.WriteLine($"{seconds} \n{minutes} \n{hours} \n{day} \n{day}.{hours}.{minutes}.{seconds} \n{inTotal}");
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

float heightInput = float.Parse(height);

float heightx2 = heightInput * heightInput;

Console.WriteLine("Write your weight in kilos:");
string weight = Console.ReadLine();

float weightInput = float.Parse(weight);

float bmiOutput = weightInput / heightx2;

Console.WriteLine("BMI = " + bmiOutput);
*/

// Exercise 8
/*
float userAdjacentInput;
float userOppositeInput;

Console.WriteLine("Write 2 number:");

userAdjacentInput = float.Parse(Console.ReadLine());
userOppositeInput = float.Parse(Console.ReadLine());

float adjacentX2 = userAdjacentInput * userAdjacentInput; 
float oppositeX2 = userOppositeInput * userOppositeInput;
float squareIt = adjacentX2 + oppositeX2;

double sum = Math.Sqrt(squareIt);
Console.WriteLine("Answer: " + sum);
*/

//Exercise 9
/*
Console.WriteLine("Give an amount of seconds:");
int seconds = int.Parse(Console.ReadLine());

int spare = seconds % 60;
int minutes = seconds / 60;

Console.WriteLine($"{seconds} = {minutes} minute(s) and {spare} second(s)");
*/
