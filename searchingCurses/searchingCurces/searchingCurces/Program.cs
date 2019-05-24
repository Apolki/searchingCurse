using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            
            var censored = profanalityFinder.Censore(songsLyrics.lyrics);
            Console.WriteLine(censored);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    class ProfanalityFinder
    {
        private string[] badWords;
        public ProfanalityFinder()
        {
            var dictFile = File.ReadAllText("profanities.txt");
            dictFile = dictFile.Replace("*", "");
            dictFile = dictFile.Replace("(", "");
            dictFile = dictFile.Replace(")", "");
            badWords = dictFile.Split(new[] { "\",\"" }, StringSplitOptions.None);
        }



       public  string Censore(string text)
        {
            foreach (var word in badWords)
            {
                text = RemoveBadWord(text, word);
            }
            return text;
        }

        private static string RemoveBadWord(string text, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(text, pattern, "____", RegexOptions.IgnoreCase);
           
            
        }
    }
}