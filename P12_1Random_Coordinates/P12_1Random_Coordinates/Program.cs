internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Boss spawn coordination");

        Random xAxes = new Random();
        int x= xAxes.Next(0, 100);

        Random yAxes = new Random();
        int y = yAxes.Next(0, 100);

        Console.WriteLine($"X {x}, " + $"Y {y}");
    }
}


