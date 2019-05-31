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
            var eminem = new Artist("Eminem");
            eminem.songTitles = new List<string>
            {
                "Lose Yourself",
                "Without Me",
                "Sing for the Moment",
            };
            eminem.ShowProfanityStats();
            var songsLyrics = new Song("Eminem", "Without me");
            var profanalityFinder = new ProfanityFinder();
            Console.WriteLine(profanalityFinder.GetBadWordsSummary(songsLyrics));
            // var censored = profanalityFinder.Censore(songsLyrics.lyrics);
           // var badWordsAmount = profanalityFinder.countBadWords(songsLyrics.lyrics);
           // Console.WriteLine(badWordsAmount);

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    internal class Artist
    {
        public string name;
        internal List<string> songTitles;

        public Artist(string name)
        {
            this.name = name;
        }

        public void ShowProfanityStats()
        {
            var profanityFinder = new ProfanityFinder();

            foreach (var title in songTitles)
            {
                var song = new Song(name, title);
                var profanitiesAmmount = profanityFinder.countBadWords(song.lyrics);
                Console.WriteLine(song.title + ": " + profanitiesAmmount);
            }
        }
    }
}