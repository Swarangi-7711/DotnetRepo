using System;
/*
Program to print the following patterns of stars
         *
        * *
       * * *
      * * * *
     * * * * *
*/
namespace file
{
    public class Star3
    {
        public static void Main(string[] args)
        {
         int i,k,j;
         int num=5;
         for(k=1;k<=num;k++)
         {
              for(i=k;i<=num;i++)
           {
            Console.Write(" ");
           }
           for(j=1;j<=k;j++)
           {
            Console.Write(" *");
           }
           Console.WriteLine("\n");
         }
          }
    }
}