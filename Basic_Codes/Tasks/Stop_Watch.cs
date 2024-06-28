/*
 C# Program to Create Stop Watch 
This C# program is used to create stop watch, it will provide a set of methods and properties that to use accurately measure elapsed time.
The Stopwatch() function is used to initialize a new instance of the Stopwatch class.The start() function is used to Starts, or resumes, measuring elapsed time for an interval.
Using for loop initialize the value of ‘i’ variable as 0 and check the value of ‘i’ variable is less than 10. If the condition is true then execute the iteration of loop.
The Stop() function is used to stop measuring elapsed time for an interval.
Elapsed is used to get the total elapsed time measured by the current instance. 
Here the stop watch is created and using for loop the time for the printing function is calculated and prints the value.
 */
using System;
using System.Diagnostics;
using System.Threading;
class Stop_Watch
{
    static void Main()
    {
        // Create new stopwatch
        Stopwatch stopwatch = new Stopwatch();
        // Begin timing
        stopwatch.Start();        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("HI");
        }
        // Stop timing
        stopwatch.Stop();
        Console.WriteLine("Time Elapsed : {0}",
            stopwatch.Elapsed);
        Console.ReadLine();
    }
}
