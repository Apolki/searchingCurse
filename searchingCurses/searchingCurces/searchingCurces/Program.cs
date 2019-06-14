using SearchingCurses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchingCurses
{
    class Program
    {
        static void Main()
        {
            var strona =  WebCache.GetOrDownload("http://google.com");
            var eminem = new Artist("Eminem");
           eminem.songTitles = new List<string>
           {
               "Lose Yourself",
               "Not Afraid",
               "Sing for the Moment",
               "Without Me",
               "The Real Slim Shady",
               "Stan",
               "Rap God",
           };
             eminem.CalculateSwearAndWordCount();
             eminem.DisplayStatistics();
            var nickiMinaj = new Artist("Nicki Minaj");
            nickiMinaj.songTitles = new List<string>
            {
                "Bang Bang",
                "Super Bass",
                "Anaconda",
                "rsthsrthrhadrgag",
            };
            nickiMinaj.CalculateSwearAndWordCount();
            nickiMinaj.DisplayStatistics();
            //var songsLyrics = new Song("Eminem", "Without me");
            // var profanalityFinder = new ProfanityFinder();
            //Console.WriteLine(profanalityFinder.GetBadWordsSummary(songsLyrics));
            // var censored = profanalityFinder.Censore(songsLyrics.lyrics);
            // var badWordsAmount = profanalityFinder.countBadWords(songsLyrics.lyrics);
            // Console.WriteLine(badWordsAmount);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
   
}
