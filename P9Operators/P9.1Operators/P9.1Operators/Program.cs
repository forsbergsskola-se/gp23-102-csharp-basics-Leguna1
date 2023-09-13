Console.WriteLine("Welcome, this is minutes to seconds converter function.");

Console.WriteLine("Give us a number of minutes: ");
string? minute=Console.ReadLine();
int s = 60;
if (minute != null)
{
    int m = int.Parse(minute);

    Console.WriteLine(m * s);
}