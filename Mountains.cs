using System;

namespace Mountains
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iNumber = 10;
            string[] sMountains = new String[iNumber];
            
            sMountains[0] = "Everest: 8,848km";
            sMountains[1] = "K2: 8,611km";
            sMountains[2] = "Kangchenjunga: 8,568km";
            sMountains[3] = "Lhotse: 8,516km";
            sMountains[4] = "Makalu: 8,485km";
            sMountains[5] = "Cho Oyu: 8,188km";
            sMountains[6] = "Dhaulagiri: 8.167m";
            sMountains[7] = "Manslu: 8,163km";
            sMountains[8] = "Nanga Parbat: 8,126km";
            sMountains[9] = "Anapurna: 8,091km";

            Console.WriteLine("Ten highest mountains");
            Console.WriteLine();
            Console.WriteLine(sMountains[0]);
            Console.WriteLine(sMountains[1]);
            Console.WriteLine(sMountains[2]);
            Console.WriteLine(sMountains[3]);
            Console.WriteLine(sMountains[4]);
            Console.WriteLine(sMountains[5]);
            Console.WriteLine(sMountains[6]);
            Console.WriteLine(sMountains[7]);
            Console.WriteLine(sMountains[8]);
            Console.WriteLine(sMountains[9]);
            
            Console.WriteLine();
            Console.WriteLine("Press any key to end the program");
            _ = Console.ReadKey();
        }
    }
}