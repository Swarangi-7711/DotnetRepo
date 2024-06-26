using System;
/*
Program to print the following patterns of stars

 * * * * *
  * * * *
   * * *
    * *
     *
*/
namespace file
{
    public class Star4
    {
         public static void Main(string[] args)
        {
         int i,k,j;
         int num=5;
         for(k=1;k<=num;k++)
         {
              for(i=1;i<=k;i++)
           {
            Console.Write(" ");
           }
           for(j=num;j>=k;j--)
           {
            Console.Write(" *");
           }
           Console.WriteLine("\n");
         }
          }
    }
}