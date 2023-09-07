using static System.Console;

WriteLine("Enter 0 or 1:");
int input = int.Parse(ReadLine()!);

int[] results = { 1, 0 };

int x = results[input];
WriteLine(+ x);

