Console.WriteLine("This program displays grades based on points");
Console.WriteLine("Enter a number between 1 and 100: ");

int grade = int.Parse(Console.ReadLine()!);

if (grade >= 90 && grade <=100)
{
    Console.WriteLine("A");
}
else if (grade >= 80 && grade <=89)
{
    Console.WriteLine("B");
}

if (70 <= grade && grade <=79)
{
    Console.WriteLine("C");
}
else if (grade >= 60 && grade <=69)
{
    Console.WriteLine("D");
}

if (grade < 60)
{
    Console.WriteLine("F");
}