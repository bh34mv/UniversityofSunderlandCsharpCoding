using System;

namespace TipTheWaiter
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and constants.
            const int iMin_Tip = 1;
            const double dTip_Percent = 0.10;
            double dBill;
            double dTip;
            
            // Input bill amount.
            Console.Write("Enter bill amount:");
            dBill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            // Calculate cost of tip.
            dTip = dBill + dTip_Percent;
            
            if (d_tip > iMin_Tip) // If tip is less than the minimum tip.
            {
                dTip = iMin_tip; // Set tip to minimum.
            }
            
            // Display bill and tip.
            Console.WriteLine("The bill is " + dBill.ToString("C"));
            Console.WriteLine("The tip should be " + dTip.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }
    }
}