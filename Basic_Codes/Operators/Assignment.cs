// C# program to learn the working of Assignment Operators
using System;
namespace file{
    
class Assignment
{
    static void Main(string[] args)
    {
            //Simple Assignment Operator "="
            int x = 40; 
            
            // it means x = x + 10
            x += 10; 
            Console.WriteLine("Add Assignment Operator: " + x);

            x = 20;
        
            x -= 10; 
            Console.WriteLine("Subtract Assignment Operator: " + x);
    
            x = 10;

            x *= 10; 
            Console.WriteLine("Multiply Assignment Operator: " + x);
 
            x = 25;

            x /= 5; 
            Console.WriteLine("Division Assignment Operator: " + x);
        
            x = 30;
   
            x %= 5; 
            Console.WriteLine("Modulo Assignment Operator: " + x);
            
            x = 8;
          
            x <<= 2; 
            Console.WriteLine("Left Shift Assignment Operator: " + x);
          
            x = 8;
      
            x >>= 2; 
            Console.WriteLine("Right Shift Assignment Operator: " + x);
          
            x = 16;
          
            x &= 4; 
            Console.WriteLine("Bitwise AND Assignment Operator: " + x);
            
            x = 12;
    
            x ^= 4; 
            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);
  
            x = 14;
            
            x |= 4; 
            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);
        
    }
}
}
