Console.WriteLine("Game Starting now.");

Random random = new Random();
int number = random.Next(1, 100);

Console.WriteLine("I have picked a number (1-100. It's your turn to guess it!");

int guess = 0;
UserInput:
int input=int.Parse(Console.ReadLine()!);
guess++;
if (input < number)
{
    Console.WriteLine("Nope! My number is Greater!");
    goto UserInput;
}
if (input > number)
{
    Console.WriteLine("Nope! My number is Smaller!");
    goto UserInput;
}

Console.WriteLine($"That's the number! Well played! You guessed it in {guess} attempts.");