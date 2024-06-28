using System;
using System.Globalization;
/*
This C# program is used to get the DayLight saving information. 
The GetDaylightChanges() function indicates whether a specified date and time falls in the range of daylight saving 
time for the time zone of the current TimeZoneInfo object.
 Then the information about the current year’s daylight saving changes is obtained.
*/
namespace file
{
    public class DayLight
    {
        public static void Main(String[] args)
            {
                TimeZone z = TimeZone.CurrentTimeZone;
                DaylightTime t = z.GetDaylightChanges(DateTime.Today.Year);
                Console.WriteLine("Start Time: {0}", t.Start);
                Console.WriteLine("Delta Time: {0}", t.Delta);
                Console.WriteLine("End Time: {0}", t.End);
                Console.ReadLine();
            }
    } 
}