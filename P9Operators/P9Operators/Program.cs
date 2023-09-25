using static System.Console;

WriteLine("Give me a number of seconds ");
var seconds = double.Parse(ReadLine()!);
var fraction = seconds / 86400;

var days = (int)(seconds / 86400);
seconds %= 86400;

var hours = (int)(seconds / 3600);
seconds %= 3600;

var minutes = (int)(seconds / 60);
seconds %= 60;

WriteLine("Seconds: " + seconds);
WriteLine("Minutes: " + minutes);
WriteLine("Hours: " + hours);
WriteLine("Days: " + days);
WriteLine($"{days}.{hours}:{minutes}:{seconds}");
WriteLine("In total, that's "+fraction+ " Days.");
