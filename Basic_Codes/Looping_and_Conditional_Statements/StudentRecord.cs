using System;
namespace file{
public class StudentRecord
{
    static void Main(string[] args)
    {

        int n;
        Console.WriteLine("Enter number of students: ");
        n=Convert.ToInt32(Console.ReadLine());
        int[] roll= new int[n];
        int[] sem= new int[n];
        string[] name=new string[n];
        string[] branch=new string[n];
        string[] clg=new string[n];
    
        
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Enter roll no: ");
            roll[i]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name: ");
            name[i]=Console.ReadLine();

            Console.WriteLine("Enter branch: ");
            branch[i]=Console.ReadLine();

            Console.WriteLine("Enter semester: ");
            sem[i]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter college: ");
            clg[i]=Console.ReadLine();

            Console.WriteLine();
        }
        Console.WriteLine("Students Record : ");
        for(int i=0;i<n;i++)
        {
            Console.WriteLine("Roll no: "+roll[i]);
            
            Console.WriteLine("Name: "+name[i]);
            
            Console.WriteLine("Branch: "+branch[i]);
            
            Console.WriteLine("Semester: "+sem[i]);
            
            Console.WriteLine("College: "+clg[i]);
            
            Console.WriteLine("------------------------------------");
        }
    }
}
}