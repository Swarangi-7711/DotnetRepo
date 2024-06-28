// Program to calculate the size of the area in 
// square-feet based on specified height and width in C#.

using System;

class SquareFeet
{
    static int calculateArea(int lengthInFeets, int widthInFeets)
    {
        return (lengthInFeets * widthInFeets);
    }
    public static void Main(String[] Args)
    {
        int lengthInFeets = 0;
        int widthInFeets = 0;
        int plotArea = 0;


        Console.Write("Enter length of the plot in feets: ");
        lengthInFeets = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter width of room in feet:");
        widthInFeets = Convert.ToInt32(Console.ReadLine());

        plotArea = calculateArea(lengthInFeets, widthInFeets);

        Console.WriteLine("Plot area is "+plotArea+" square feet");
    }
}