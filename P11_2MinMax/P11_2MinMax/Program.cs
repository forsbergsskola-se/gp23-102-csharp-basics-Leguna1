//Asks the user to input three numbers and then displays the minimum and maximum of those numbers.

Console.WriteLine("Enter three number: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

if (num1 > num2 && num1 > num3 && num2 < num3)
{
    Console.WriteLine(""+num1+","+num2);
}
else if (num2 > num1 && num2 > num3 && num1 > num3)
{
    Console.WriteLine(""+num2+","+num3);
}
else
{
    Console.WriteLine("" +num3+ "," +num1);
}