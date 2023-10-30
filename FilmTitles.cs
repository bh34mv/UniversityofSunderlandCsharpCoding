using System;

namespace FilmTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sFilmTitle;

            Console.WriteLine("Films with one word titles: ");
            Console.WriteLine();
            Console.WriteLine("Film 1: 2012");
            Console.WriteLine("Film 2: Brave");
            Console.WriteLine("Film 3: Cars");
            Console.WriteLine("Film 4: Goal!");
            Console.WriteLine("Film 5: Madagascar");
            Console.WriteLine("Film 6: Shrek");
            Console.WriteLine("Film 7: Titanic");
            using (StreamReader sr = new StreamReader("filenames.txt"));
        }
    }
}