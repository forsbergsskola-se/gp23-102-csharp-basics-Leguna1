Console.WriteLine("What's your age?");
// console input && variable && type
string ageInput = Console.ReadLine();
// conversion && variable && type
int age = int.Parse(ageInput);
// conditional branching && boolean expressions && comparison operator
if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if (age <= 19)
{
    Console.WriteLine("You are a teen.");
}
else
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Give me another integer.");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);

// number or age (whatever is greater)
var max = number > age ? number : age;
Console.WriteLine($"The maximum is {max}.");
if (max % 2 == 0)
{
    Console.WriteLine("It's an even number.");
}
else
{
    Console.WriteLine("It's an odd number.");
}