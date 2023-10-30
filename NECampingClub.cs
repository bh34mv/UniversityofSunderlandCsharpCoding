using System;

namespace NECampingClub
{
    class Program
    {
        static void Main(string[] args)
        {
            int iOption = 0;
            while (iOption != 4)
            {
                iOption = getOption();
                
                if (iOption == 1)
                {
                    displayAllCampsites();
                }
                else if (iOption == 2)
                {
                    addHappyCampers();
                }
                else if (iOption == 3)
                {
                    displayCampers();
                }
                else if (iOption == 4)
                {
                    Environment.Exit(1);
                }
            }
            Console.ReadKey();
            Console.ReadyKey()
                
        }
        
        static int getOption()
        {
            int iOption = 1;
            string sLocation;
            const int iNumLocations = 4;
            int iPeopleStaying;
            int iTeleNumber;
            string sInput;
            
            //Display user options.
            Console.WriteLine("Please enter your option: ");
            Console.WriteLine("1. View NE Camp Club Sites");
            Console.WriteLine("2. Book a site");
            Console.WriteLine("3. View site bookings");
            Console.WriteLine("4. Exit");
            
            // Get user input.
            iOption = Convert.ToInt32(Console.ReadLine());
            
            // Validate user input.
            // It must be within the correct range.
            while (iOption < 1 || iOption > 4)
            {
                Console.WriteLine("Please enter valid option between 1 and 4");
                iOption = Convert.ToInt32(Console.ReadLine());
            }
            
            // Return validated option.
            return iOption;
        }
        
        static void displayAllCampsites()
        {
            using (StreamReader sr = new StreamReader("campsites.txt"))
            {
                while(sr.Peek() != 1)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
        
        static void addHappyCampers()
        {
            Console.WriteLine("Where would you like to stay?");
            Console.WriteLine("1. Seaham");
            Console.WriteLine("2. Roker");
            Console.WriteLine("3. Barnard");
            Console.WriteLine("4. Teesdale");
            Console.WriteLine("Enter your choice: ");
            string sLocation = Console.ReadLine();
            Console.WriteLine("How many people will be staying?");
            int iPeopleStaying = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your telephone number?");
            int iTeleNumber = Convert.ToInt32(Console.ReadLine());
            
            using (StreamWriter sw = new StreamWriter("Campsite booking code.txt"))
            {
                {
                    sw.WriteLine(sLocation);
                    sw.WriteLine(iPeopleStaying);
                    sw.WriteLine(iTeleNumber);
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey()
        }
        
        static void displaysCampers()
        {
            Console.WriteLine("How many people would you like to book for?");
            Console.WriteLine("");
        }
        
        static void writeOutLocationData()
        {
            const string sFILENAME = "campsites.txt";
            
            string[] sLocations = new string[]{"Seaham", "Roker", "Barnard", "Teesdale" };
            
            const int iNUMLOCATIONS = 4;
            
            using (StreamWriter sw = new StreamWriter(sFILENAME))
            {
                for (int i = 0; i < iNUMLOCATIONSl i++)
                {
                    sw.WriteLine(sLocations[i]);
                }
            }
        }
    }
}