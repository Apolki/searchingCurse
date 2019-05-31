using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchingCurses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("artist = ");
            string artist = Console.ReadLine();
            Console.Write("title = ");
            string title = Console.ReadLine();*/
            var songsLyrics = new SongLyrics("Eminem", "Without me");
            var profanalityFinder = new ProfanalityFinder();
            Console.WriteLine(profanalityFinder.GetBadWordsSummary(songsLyrics));
            // var censored = profanalityFinder.Censore(songsLyrics.lyrics);
            //var badWordsAmount = profanalityFinder.countBadWords(songsLyrics.lyrics);
            Console.WriteLine(badWordsAmount);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}