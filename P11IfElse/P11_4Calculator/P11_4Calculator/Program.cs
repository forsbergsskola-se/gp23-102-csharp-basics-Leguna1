public class Calculator
{
    private static void Main()
    {
        Console.WriteLine("Use operators: `+` `-` `*` `/`");
        Console.WriteLine("Enter a number: ");
        float num1 = float.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the operator: ");
        string? symbol = Console.ReadLine();

        Console.WriteLine("Enter another number: ");
        float num2 = float.Parse(Console.ReadLine()!);

        if (symbol == "+")
        {
            Console.WriteLine(num1 + num2);
        }
        else if (symbol == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if (symbol == "/")
        {
            // Cant divide by zero
            if (num2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
        }
        else
        {
            Console.WriteLine(num1 * num2);
        }
    }
}