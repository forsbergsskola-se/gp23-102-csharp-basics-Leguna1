//Write a program that takes an integer input representing seconds and converts it to minutes and remaining seconds,
//then displays the result.

using static System.Console;

WriteLine("Seconds to minutes converter.");

WriteLine("Enter the seconds: ");
var seconds =float.Parse(ReadLine()!);

var minutes = seconds /60;

WriteLine(minutes +" minutes");

