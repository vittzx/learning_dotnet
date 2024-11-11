using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.CompilerServices;

public class Variables { 
    
    
    public static void teste()
    {
        const int integer = 123; // imutable
        int integer2 = 234;
        // double double_number = 12.23;
        bool alive = false;
        char symbol = 'a';

        int response = integer + integer2;

        double new_number = Convert.ToDouble(integer);

        Console.WriteLine(alive.GetType());
        Console.WriteLine(symbol.GetType());
        Console.WriteLine(response);
    }



    public static String printString()
    {
        return "print string that wich one is green";
    }


    public static string printString2()
    {
        return "string that is blue";
    }

}