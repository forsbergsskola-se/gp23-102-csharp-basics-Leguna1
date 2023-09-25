// Develop a program that calculates the BMI of a person using their weight in kilograms and height in meters.
// Display the BMI value. (probably requires google for the Maths)


Console.WriteLine("This is a BMI Calculator.");

Console.WriteLine("Type your weight in kilograms: ");
float weight= float.Parse(Console.ReadLine()!);

Console.WriteLine("Type your height in meters: ");
float height= float.Parse(Console.ReadLine()!);

float result = weight / (height * height);
Console.WriteLine(result + " kg/m2");
