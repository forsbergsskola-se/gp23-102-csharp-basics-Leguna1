Console.WriteLine("This is a program that calculates the area of a circle.");

Console.WriteLine("Enter the radius: ");
float radius = float.Parse(Console.ReadLine());

float area=MathF.PI * radius * radius;
Console.WriteLine(area); 