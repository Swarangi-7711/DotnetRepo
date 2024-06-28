using System;

namespace file
{
    public class Searching
    {
        public static void Main()
        {
          int j;
          int[] arr=new int[10];
          Console.WriteLine("\nEnter the element : ");
          for(int i=0;i<10;i++)
          {
           arr[i]= Convert.ToInt32(Console.ReadLine());
          }
          Console.WriteLine("\nEnter the element search : ");
          int n = Convert.ToInt32(Console.ReadLine());
          for(j=0;j<10;j++)
          {
            if(arr[j]==n)
            {
                Console.WriteLine("Element "+n+" is present at position "+(j+1));
                break;
            }
          }
          if(j==10)
          {
             Console.WriteLine("Element "+n+" is not present in array");
          }
        }

     }
}