using System;

namespace BooksToRead
{
    class Program
    {
        static void Main(string[] args)
        {
            int iChoice; //Menu choice.
            string sBook; //Name of book.
            int iNumBooks; //Number of books to enter.
            int iIndex; //Loop Counter.
            
            Console.WriteLine("1. Add Books");
            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Exit Program");
            Console.WriteLine("Enter your choice: ");
            iChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            while (iChoice < 1 || iChoice > 3)
            {
                Console.Write("You must enter a number between 1 and 3, please re-enter: ");
                iChoice = Convert.ToInt32(Console.ReadLine());
            }
            
            //Validate menu choice.
            while (iChoice != 3)
            {
                if (iChoice == 1) //Create book file.
                {
                    Console.Write("How many books do you want to enter? ");
                    iNumBooks = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    
                    //Open data file for writing in APPEND mode.
                    using (StreamWriter sw =
                           new StreamWriter("BooksToRead.txt", true))
                    {
                        //Loop for each book.
                        for (iIndex = 1; iIndex <= iNumBooks; iIndex++)
                        {
                            Console.Write("Enter book " + iIndex + ": ");
                            sBook = Console.ReadLine();
                            //Write book to data file.
                            sw.WriteLine(sBook);
                            Console.WriteLine();
                        }
                    }
                }
                else //Read books from data file.
                {
                    Console.WriteLine("*** Books on file ***");
                    
                    //Open data file for reading.
                    using (StreamReader sr = new StreamReader("BooksToRead.txt"))
                    {
                        iIndex = 0; //Start counting.
                        while(sr.Peek() != -1) //While not at end of file.
                        {
                            sBook = sr.ReadLine(); //Read book from file.
                            iIndex++; //Increment counter.
                            Console.WriteLine(sBook);
                        }
                        
                        //Display count of books on file.
                        Console.WriteLine();
                        Console.WriteLine(iIndex + " books on file.");
                        Console.WriteLine();
                    }
                }
                
                //Re-display menu.
                Console.WriteLine("1. Add Books");
                Console.WriteLine("2. Display Books.");
                Console.WriteLine("3. Exit program");
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine();
                
                iChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine());
                
                //Validate menu choice
                while (iChoice < 1 || iChoice > 3)
                {
                    Console.Write("You must enter a number between 1 and 3, please re-enter: ");
                    iChoice = Convert.ToInt32(Console.ReadLine());
                }
            } //End of main while loop.
        }
    }
}