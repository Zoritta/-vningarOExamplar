using System;

namespace simpleArrays;
class Program
{
    static void Main()
    {
        string name = "Jensen Education";
        string character = name.Substring(7, 4);
        Console.WriteLine(character);
        var words = name.Split(' ');
        Console.WriteLine(words[0]);  
        Console.WriteLine(words[1]);

        double value1 = 7988.6795;
        double value2 = 7988.6888;
        Console.WriteLine("Values are " + value1 + " and " + value2);
        Console.WriteLine("Values are {0:N2} and {1:N}", value1, value2);
    } 
}