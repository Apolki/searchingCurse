using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchingCurses
{
    class Program
    {
        static void Main()
        {
            var webCache = new WebCache();
            var eminem = new Artist("Eminem");
            eminem.songTitles = new List<string>
            {
                "Lose Yourself",
                "Without Me",
                "Sing for the Moment",
            };
            eminem.CalculateSwearAndWordCount();
            eminem.DisplayStatistics();
            //var songsLyrics = new Song("Eminem", "Without me");
            var profanalityFinder = new ProfanityFinder();
            //Console.WriteLine(profanalityFinder.GetBadWordsSummary(songsLyrics));
            // var censored = profanalityFinder.Censore(songsLyrics.lyrics);
           // var badWordsAmount = profanalityFinder.countBadWords(songsLyrics.lyrics);
           // Console.WriteLine(badWordsAmount);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    class WebCache
    {
        public WebCache()
        {

        }
    }
}