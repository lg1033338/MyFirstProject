// See https://aka.ms/new-console-template for more information
/* This is a 
multi-line comment! */
/// This is going to ask user for their names.
Console.WriteLine("What is your first name?");
Console.Write(">>> ");
string firstName = Console.ReadLine();
Console.WriteLine("What is your last name?");
Console.Write(">>> ");
string lastName = Console.ReadLine() + "";
/// Now its combining it to say welcome
Console.WriteLine("Hello " + firstName + " " + lastName + "!");
/// Now its asking for 3 postive numbers 
Console.WriteLine("Give me one random postive number!");
Console.Write(">>> ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give me one random postive number!");
Console.Write(">>> ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give me one random postive number!");
Console.Write(">>> ");
int z = Convert.ToInt32(Console.ReadLine());
/// It uses these numbers to add, subtract, and do other things
Console.WriteLine(x + y + z);
int a = x + y + z;
Console.WriteLine(y - x);
Console.WriteLine(x * z);
int b = x * z;
Console.WriteLine(a / y);
Console.WriteLine(x % b);