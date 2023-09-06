using static System.Console;

WriteLine("Give me a number of seconds ");
double seconds = double.Parse(ReadLine()!);
double fraction = seconds / 86400;

int days = (int)(seconds / 86400);
seconds %= 86400;

int hours = (int)(seconds / 3600);
seconds %= 3600;

int minutes = (int)(seconds / 60);
seconds %= 60;

WriteLine("Seconds: " + seconds);
WriteLine("Minutes: " + minutes);
WriteLine("Hours: " + hours);
WriteLine("Days: " + days);
WriteLine($"{days}.{hours}:{minutes}:{seconds}");
WriteLine("In total, that's "+fraction+ " Days.");

