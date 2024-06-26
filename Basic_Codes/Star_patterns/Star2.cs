using System;
/*
Program to print the following patterns of stars
*****
****
***
**
*

*/
namespace file
{
    public class Star2
    {
         static void Main(string[] args)
        {
           int i,j;
           for(i=5; i>=0; i--)
           {
              j=0;
              while(j<=i)
              {
                Console.Write(" ");
                Console.Write(" *");
                j++;
              } 
              Console.Write("\n");
           }
        }
    }
}