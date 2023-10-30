using System;

namespace Weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iWeek = 7;
            string[] sDays = new string[iWeek];
            
            sDays[0] = "Monday";
            sDays[1] = "Tuesday";
            sDays[2] = "Wednesday";
            sDays[3] = "Thursday";
            sDays[4] = "Friday";
            sDays[5] = "Saturday";
            sDays[6] = "Sunday";
            
            Console.WriteLine("The days of the week: ");
            Console.WriteLine();
            Console.WriteLine(sDays[0]);
            Console.WriteLine(sDays[1]);
            Console.WriteLine(sDays[2]);
            Console.WriteLine(sDays[3]);
            Console.WriteLine(sDays[4]);
            Console.WriteLine(sDays[5]);
            Console.WriteLine(sDays[6]);
            
            Console.WriteLine();
            Console.WriteLine("Press any key to end the program");
            _ = Console.ReadKey();
        }
    }
}