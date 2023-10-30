using System;

namespace CrispMachine;
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOption;
            int iNumCrisps = 0;
            
            while (true)
            {
                //Get menu option.
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Fill machine with crisps");
                Console.WriteLine("2. Buy crisps");
                Console.WriteLine("3. Inspect machine");
                Console.WriteLine("4. Exit");
                iOption = Convert.ToInt32(Console.ReadLine());
                
                if (iOption == 1)
                {
                    FillCrisps(ref iNumCrisps);
                    Console.WriteLine(iNumCrisps);
                }
                else if (iOption == 2)
                {
                    BuyCrisps(ref iNumCrisps);
                    Console.WriteLine(iNumCrisps);
                }
                else if (iOption == 3)
                {
                    InspectCrisps(ref iNumCrisps);
                    Console.WriteLine(iNumCrisps);
                }
                else if (iOption == 4)
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}