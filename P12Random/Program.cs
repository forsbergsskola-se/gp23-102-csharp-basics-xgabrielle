/*
Console.WriteLine("Please pass me a seed:");
int userInput = int.Parse(Console.ReadLine());

Random rand = new Random(userInput);
int a = rand.Next(0,5);
int b = rand.Next(2,5);
int c = rand.Next(0,5);
Console.WriteLine($"Three integers between 0 and 5:\n{a}\n{b}\n{c}");

double d = rand.NextDouble()*0.5;
double e = rand.NextDouble()*0.5;
double f = rand.NextDouble()*0.5;
Console.WriteLine($"Three numbers between 0.0 and 0.5:\n{d}\n{e}\n{f}");

double g = rand.NextDouble()*0.5+.2;
double h = rand.NextDouble()*0.5+.2;
double i = rand.NextDouble()*0.5+.2;
Console.WriteLine($"Three numbers between 0.2 and 0.7:\n{g}\n{h}\n{i}");

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double userChanceInput = double.Parse(Console.ReadLine());

Console.WriteLine(rand.NextDouble() < userChanceInput ? "crit" : "no Crit");
Console.WriteLine(rand.NextDouble() < userChanceInput ? "crit" : "no Crit");
Console.WriteLine(rand.NextDouble() < userChanceInput ? "crit" : "no Crit");
Console.WriteLine(rand.NextDouble() < userChanceInput ? "crit" : "no Crit");
Console.WriteLine(rand.NextDouble() < userChanceInput ? "crit" : "no Crit");
*/

// P12_2Random_Password
/*
Random password = new Random();
int newPass = password.Next(1,999999);
Console.WriteLine(newPass);
*/

// P12_4Random_Chance
/*
Random chance = new Random();
double userChance = chance.NextDouble();

if (userChance <.1)
    Console.WriteLine("Here's your secret message.... nothing juicy");

else
    Console.WriteLine("No secret for you");
*/