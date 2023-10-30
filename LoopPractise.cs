using System;

namespace LoopPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice;
            
            Console.WriteLine("Enter your name: ");
            iChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            // Validate menu choice.
            while (iChoice < 1 || iChoice > 3)
            {
                Console.Write("You must enter a number between 1 and 3, please re-enter: ");
                iChoice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}