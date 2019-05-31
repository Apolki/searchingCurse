using System;
using System.Collections.Generic;

namespace searchingCurses
{
    internal class Artist
    {

        public string name;
        internal List<string> songTitles;
        public int wordCount;
        public int swearCount;

        public Artist(string name)
        {
            this.name = name;
        }

        public void CalculateSwearAndWordCount()
        {
            wordCount = 0;
            swearCount = 0;
            var profanityFinder = new ProfanityFinder();

            foreach (var title in songTitles)
            {
                var song = new Song(name, title);
                swearCount += profanityFinder.countBadWords(song.lyrics);
                wordCount += song.CountWords();
               
            }
        }

        public void DisplayStatistics()
        {
            int profanityIndex = wordCount / swearCount;
            Console.WriteLine("Dla artysty: " + name + " co " + profanityIndex + " to przekleństwo");
        }
    }
}