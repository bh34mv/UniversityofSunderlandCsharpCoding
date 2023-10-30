using System.IO;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOption;
            double dAmount;
            double dBalance;
            
            Console.WriteLine("Simple Bank Account");
            Console.WriteLine();
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Withdraw money");
            Console.WriteLine("3. Display statement");
            Console.WriteLine("4. Exit");
            
            Console.WriteLine();
            Console.Write("Enter option (1-4): ");
            iOption = Convert.ToInt32(Console.ReadLine());
            
            while (iOption != 4)
            {
                switch (iOption)
                {
                    case 1: //Deposit money.
                        Console.Write("Enter amount and add to balance");
                        dAmount = Convert.ToDouble(Console.ReadLine());
                        dBalance = dBalance + dAmount;
                        break;
                        
                    case 2: //Withdraw money.
                        Console.Write("Enter amount and deduct from balance: ");
                        dAmount = Convert.ToDouble(Console.ReadLine());
                        if (dAmount > dBalance)
                        {
                            Console.WriteLine("Insufficient funds to withdraw " + dAmount.ToString("C"));
                            Console.WriteLine("Balance in account is " + dBalance.ToString("C"));
                        }
                        else
                        {
                            dBalance = dBalance - dAmount;
                        }
                        dBalance = dBalance - dAmount;
                        break;
                        
                    case 3: //Display statement.
                        using (StreamReader sr = new StreamReader(sFILENAME))
                        {
                            while (sr.Peek() != -1)
                            {
                                Console.WriteLine(sr.ReadLine());
                            }
                        }
                        break;
                }
                //Display menu again, read meny choice into iOption.
            }
        }
    }
}