Console.WriteLine("The Magic Number");

Random random = new Random();
double tryAgain = random.NextDouble();

double chance = 0.1; 

if (tryAgain <= chance)
{
    Console.WriteLine("You got the magic number [1] ;)");
}
else
{
    Console.WriteLine((tryAgain).ToString("[0.0]")+ " Try Again");
}