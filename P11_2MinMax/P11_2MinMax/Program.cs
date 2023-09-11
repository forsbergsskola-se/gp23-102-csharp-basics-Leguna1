Console.WriteLine("Enter three numbers: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

int min, max;

// Minimum number
if (num1 <= num2 && num1 <= num3)
{
    min = num1;
}
else if (num2 <= num1 && num2 <= num3)
{
    min = num2;
}
else
{
    min = num3;
}

// Maximum number
if (num1 >= num2 && num1 >= num3)
{
    max = num1;
}
else if (num2 >= num1 && num2 >= num3)
{
    max = num2;
}
else
{
    max = num3;
}

Console.WriteLine($"{min}," + $"{max}");