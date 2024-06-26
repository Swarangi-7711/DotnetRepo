/*
 C# program to learn how while loop works
 This program is converting the decimal no. into binary.
*/
using System;
namespace file
{
    public class DecitoBinary
    {
        public static void Main(string[] args)
        {      
            int i=0;
            int[] a=new int[10];
            Console.WriteLine("Enter the no. to convert in Binary : ");
            int num=Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
              a[i]= num%2;
              num=num/2;
              i++;
            }
            for(int j=i;j>=0;j--)
            {
                Console.Write(""+a[j]);
            }
        }
    }
}