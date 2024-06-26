using System;
/* 
Program to print the following patterns of stars

    *
    **
    ***
    ****
*/
namespace file
{
    public class Star1
    {
        public static void Main(string[] args)
        {
         int k,j;
         int num=5;
         for(k=1;k<=num;k++)
         {
           for(j=1;j<=k;j++)
           {
            Console.Write(" *");
           }
           Console.WriteLine("\n");
         }
          }
    }
}