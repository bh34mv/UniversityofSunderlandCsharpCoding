using System;

namespace KitKats
{
    
    class Program
    {
        const type name = value;
        static void Main(string[] args)
        {
            // Declare constants
            const int iWeeksInYear = 52;
            const int iKitKatCal = 250;
            
            // Declare variables
            int iKitKatsWeek;
            int iKitKatsYear;
            int iCaloriesYear;
            
            // Read in number of kitkats eaten in week.
            Console.WriteLine("How many kitkats do you eat in a week?");
            iKitKatsWeek = Convert.ToInt32(Console.ReadLine());
            
            // Calculate number of kitkats eaten in a year.
            iKitKatsYear = iKitKatsWeek * iWeeksInYear;
            
            // Calculate number of calories in a year.
            iCaloriesYear = iKitKatCal * iKitKatsYear;
            
            // Output results
            Console.WriteLine();
            Console.WriteLine(iKitKatsYear + " Chunky KitKats in a year is " + iCaloriesYear + "calories!!");
            
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}