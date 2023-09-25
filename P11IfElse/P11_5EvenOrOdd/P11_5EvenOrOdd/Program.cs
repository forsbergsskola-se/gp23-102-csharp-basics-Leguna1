Console.WriteLine("Even or Odd checker");

Console.WriteLine("Enter a number: ");
int number =int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("That's even.");
}
else
{
    Console.WriteLine("That's odd.");
}