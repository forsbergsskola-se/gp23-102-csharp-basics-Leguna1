Console.WriteLine("Random Item Drop");

Random random = new Random();
int randomNumber = random.Next(1, 6);

if (randomNumber == 1)
{
    Console.WriteLine("Sword");
}
else if (randomNumber ==2)
{
    Console.WriteLine("Shield");
}
else if (randomNumber == 3)
{
    Console.WriteLine("Dagger");
}
else if (randomNumber == 4)
{
    Console.WriteLine("Bow");
}
else
{
    Console.WriteLine("Staff");
}