// See https://aka.ms/new-console-template for more information5


Console.WriteLine("How old are you?");
string age = Console.ReadLine();
int ageInput = int.Parse(age);

bool isChild = ageInput <= 12;
bool isTeenager = ageInput >= 13 && ageInput <=19;
bool isGrownup = ageInput >= 19;

Console.WriteLine($"You're a child {isChild} \n You're a teenager {isTeenager} \n You're an adult {isGrownup}");

