// C# program to learn the working of Relational Operators
using System;
namespace file {
class Relational 
{   
    static void Main(string[] args)
    {
        bool res;
        int x = 20, y = 10;
        
        // Equal to Operator
        res = (x == y);
        Console.WriteLine("Equal to Operator: " + res);
        
        // Greater than Operator
        res = (x > y);
        Console.WriteLine("Greater than Operator: " + res);
        
        // Less than Operator
        res = (x < y);
        Console.WriteLine("Less than Operator: " + res);
        
        // Greater than Equal to Operator
        res = (x >= y);
        Console.WriteLine("Greater than or Equal to: "+ res);
        
        // Less than Equal to Operator
        res = (x <= y);
        Console.WriteLine("Lesser than or Equal to: "+ res);
        
        // Not Equal To Operator
        res = (x != y);
        Console.WriteLine("Not Equal to Operator: " + res);
    }
}
}