using System;

namespace RepetitionPractise
{
    
    class Program
    {
        
        static void Main(string[] agrs)
        {
            int iChoice = 0; //Menu choice.
            int iIndex; //Loop counter.
            
            while (iChoice != 3)
            {
                if (iChoice == 1)
                {
                    //Do option 1.
                }
                else if (iChoice == 2)
                {
                    //Do option 2.
                }
                Console.WriteLine("1. Option 1");
                Console.WriteLine("2. Option 2");
                Console.WriteLine("3. Exit the program");
                Console.WriteLine("Enter your choice");
                Console.WriteLine();
                Console.WriteLine("Press any key to close.");
                iChoice = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadKey(); //End of program.
        }
    }
}