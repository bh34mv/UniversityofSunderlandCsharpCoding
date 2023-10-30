using System;

namespace BirthdayMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            
            Console.WriteLine("Enter name: ");
            sName = Console.ReadLine();
            Console.WriteLine();
            SayHappyBirthday();
            SayHappyBirthday();
            Console.WriteLine("Happy Birthday dear " + sName);
            SayHappyBirthday();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        static void SayHappyBirthday()
        {
            Console.WriteLine("Happy Birthday to you");
        }
    }
}