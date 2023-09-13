Console.WriteLine("Please pass me a seed (integer):");
int seed = int.Parse(Console.ReadLine()!);

Random random = new Random(seed);

Console.WriteLine("Three integers between 0 and 5:");
int int1 = random.Next(1, 5);
int int2 = random.Next(1, 5);
int int3 = random.Next(1, 5);

Console.WriteLine(int1);
Console.WriteLine(int2);
Console.WriteLine(int3);

Console.WriteLine("Three numbers between 0.0 and 0.5");

double double1 =random.NextDouble() *0.5;
double double2 =random.NextDouble() *0.5;
double double3 =random.NextDouble() *0.5;

Console.WriteLine(double1);
Console.WriteLine(double2);
Console.WriteLine(double3);

Console.WriteLine("Three number between 0.2 and 0.7");
double double4 =random.NextDouble() *0.5 +0.2;
double double5 =random.NextDouble() *0.5 +0.2;
double double6 =random.NextDouble() *0.5 +0.2;
Console.WriteLine(double4);
Console.WriteLine(double5);
Console.WriteLine(double6);

Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");

double critChance = double.Parse(Console.ReadLine()!);

Console.WriteLine(random.NextDouble() <= critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() <= critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() <= critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() <= critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() <= critChance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() <= critChance ? "Crit" : "No Crit");

