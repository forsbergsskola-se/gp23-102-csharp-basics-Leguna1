static class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a single character: ");
        char inputChar = Console.ReadKey().KeyChar;

        if (char.IsDigit(inputChar))
        {
            Console.WriteLine("\nThat's a digit.");
        }
        else if ((inputChar >= 'a' && inputChar <= 'z') || (inputChar >= 'A' && inputChar <= 'Z'))
        {
            char lowercaseChar = char.ToLower(inputChar);
            if (lowercaseChar == 'a' || lowercaseChar == 'e' || lowercaseChar == 'i' || lowercaseChar == 'o' || lowercaseChar == 'u')
            {
                Console.WriteLine("\nYou entered a vowel.");
            }
            else
            {
                Console.WriteLine("\nThat's a consonant.");
            }
        }
       
    }
}