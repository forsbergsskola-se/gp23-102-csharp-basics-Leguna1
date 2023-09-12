namespace P12_2Random_Password;

class Program
{
    static void Main()
    {
        Random random = new Random();
        // ASCII character numbers from 33 to 57
        char char1 = (char)random.Next(33, 57); 
        char char2 = (char)random.Next(33, 57);
        char char3 = (char)random.Next(33, 57);
        char char4 = (char)random.Next(33, 57);
        char char5 = (char)random.Next(33, 57);
        char char6 = (char)random.Next(33, 57);
        
        Console.WriteLine($"{char1}"+$"{char2}"+$"{char3}"+$"{char4}"+$"{char5}"+$"{char6}");
    }
}