// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number.");

string number = Console.ReadLine();

double dbl = Convert.ToDouble(number);
Console.WriteLine(dbl);

int sgl = Convert.ToInt32(dbl);
Console.WriteLine(sgl);

int og = Convert.ToInt32(number);
Console.WriteLine(og);

// Idea??
/* 
Console.ReadLine() = whole;
double whole = number;
int i = Convert.ToInt32(whole);
*/
