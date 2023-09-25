    using System.Globalization;

    Console.WriteLine("Give me a number."); //We telling the user to give us a number.
    
    string answer= Console.ReadLine(); //We reading the given string.
    double d = Convert.ToDouble(answer, CultureInfo.InvariantCulture); //We converting given string to double.
    Console.WriteLine(d); //We displaying given string answer in double answer.
    
    int i = (int)d; //We converting double answer to integer.
    Console.WriteLine(i); //We displaying the integer format to the user.
    
    int originalToInt = int.Parse(answer); //We trying to convert previously given string answer directly to integer.
    Console.WriteLine(originalToInt); //We displaying the outcome of the step above.
