//Write a program that takes an integer input representing seconds and converts it to minutes and remaining seconds,
//then displays the result.

using static System.Console;

WriteLine("Seconds to minutes converter.");

Write("Enter the seconds: ");
var seconds =int.Parse(ReadLine()!);

var minutes = seconds /60;
int mod = seconds % 60;

Write(minutes + " min ");
WriteLine(mod + " sec");

    

