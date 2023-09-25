namespace P9OperatorsExercise8;

public static class Program
{
    private static void Main()
    {
        Console.WriteLine("Hypotenuse Calculator");
        
        Console.Write("Enter the length of the first side: "); //input
        var side1 = Convert.ToDouble(Console.ReadLine()); //process

        Console.Write("Enter the length of the second side: "); //input
        var side2 = Convert.ToDouble(Console.ReadLine()); //process

        var hypotenuse = CalculateHypotenuse(side1, side2); //process
        Console.WriteLine($"The length of the hypotenuse is: {hypotenuse:F2}"); //output

    }
//process before output
    private static double CalculateHypotenuse(double side1, double side2)
    {
        return Math.Sqrt((side1 * side1) + (side2 * side2));
    }
}