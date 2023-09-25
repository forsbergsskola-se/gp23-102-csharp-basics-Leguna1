using static System.Console;

WriteLine("What's your age? ");
int age= int.Parse(ReadLine()!);

bool isChild = age < 13;
bool isTeenager= age >=13 && age <=19;
bool isGrownup = age > 19;

WriteLine($"You are a child:{isChild}");
WriteLine($"You are a child:{isTeenager}");
WriteLine($"You are a child:{isGrownup}");