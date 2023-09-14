internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Nim!");
        Console.WriteLine("|||||||||||||||||||||||| (24)");

        int matches = 24;
        while (matches > 0)
        {

            // Player's turn
            PlayerStarts:
            Console.WriteLine("How many matches do you want to draw?");
            PlayerDraws:
            int playerDraw = int.Parse(Console.ReadLine()!);

            if (playerDraw < 1 || playerDraw > 3 || playerDraw > matches)
            {
                Console.WriteLine("You can only draw 1-3 matches, try again.");
                goto PlayerStarts;
            }

            matches -= playerDraw;

            if (matches == 1 || matches <=playerDraw)
            {
                Console.WriteLine($"You draw {playerDraw} matches.");
                Console.WriteLine("You lose. GAME OVER!");
            }

            Console.WriteLine(new string('|', matches) + $" ({matches})");

            // AI's turn
            int aiDraw = new Random().Next(1, 4);
            if (aiDraw < matches || matches > 0)
            {
                matches -= aiDraw; 
                
                Console.WriteLine($"AI draws {aiDraw} matches.");
                Console.WriteLine(new string('|', matches) + $" ({matches})");
                goto PlayerDraws;
                
            }
            if ( matches ==2 && aiDraw >= matches || matches ==3 && aiDraw >=matches)
            {
                Console.WriteLine("You WIN!");
            }
        }
    }
}