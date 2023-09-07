Console.WriteLine("What's your age? ");
int ageInput= int.Parse(Console.ReadLine()!);

if (ageInput < 13)
{
    Console.WriteLine("You are a child");
}
else if (ageInput <= 19)
{
    Console.WriteLine("You are a teenager");
}
else
{
    Console.WriteLine("You are a grown-up");
}