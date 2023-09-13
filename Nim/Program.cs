Console.WriteLine("Welcome to Nim!");
//string match = (Convert.ToChar(124)).ToString();
int unicode = 124;
char character = (char) unicode;
string match = character.ToString();
for (int i = 0; i<24; i++)
    Console.Write(match);

Console.WriteLine("\nHow many matches do you want to draw?");
int userMatches = int.Parse(Console.ReadLine());

//int j =2;
//int k =3;
//int l;
for (int i = 24; i > 1; i--)
{
    if (userMatches == 1)
    {
        Console.Write(match);
    }
    
        
    
    
}



    
    
    