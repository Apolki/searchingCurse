using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchingCurses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("artist = ");
            string artist = Console.ReadLine();
            Console.Write("title = ");
            string title = Console.ReadLine();
            //var songsLyrics = new SongLyrics(artist, title);
            var profanalityFinder = new ProfanalityFinder("no, kurwa");
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    class ProfanalityFinder
    {
        public ProfanalityFinder(string text)
        {
            var dictFile = File.ReadAllText("profanities.txt");
        }
    }
}