// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number.");

string numberInput = Console.ReadLine();

double dbl = double.Parse(numberInput);
Console.WriteLine(dbl);

int sgl = (int) dbl;
Console.WriteLine(sgl);

int og = int.Parse(numberInput);
Console.WriteLine(og);

// Idea??
/* 
Console.ReadLine() = whole;
double whole = number;
int i = Convert.ToInt32(whole);
*/
