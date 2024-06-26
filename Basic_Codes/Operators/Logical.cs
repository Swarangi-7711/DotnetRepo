// C# program to learn the working of Logical Operators.
using System;
namespace file
{  
class Logical
{
    static void Main(string[] args)
    {
            bool a = true,b = false, res;
        
            // AND operator
            res = a && b;
            Console.WriteLine("AND Operator: " + res);
            
            // OR operator
            res = a || b;
            Console.WriteLine("OR Operator: " + res);
            
            // NOT operator
            res = !a;
            Console.WriteLine("NOT Operator: " + res);
        
    }
}
}
