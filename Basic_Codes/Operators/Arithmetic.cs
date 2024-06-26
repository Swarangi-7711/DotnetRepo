// C# program to learn the working of Binary Arithmetic Operators
using System;
namespace file
{
    class Arithmetic
    {
        
        public static void Main(string[] args)
        {
            
            int res;
            int x = 30, y = 10;
            
            // Addition
            res = x + y;
            Console.WriteLine("Addition Operator: " + res);
            
            // Subtraction
            res = x - y;
            Console.WriteLine("Subtraction Operator: " + res);
            
            // Multiplication
            res = x * y;
            Console.WriteLine("Multiplication Operator: "+ res);
            
            // Division
            res = x / y;
            Console.WriteLine("Division Operator: " + res);
            
            // Modulo
            res = x % y;
            Console.WriteLine("Modulo Operator: " + res);
        }
    }
}
