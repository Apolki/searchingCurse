using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace searchingCurses
{
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

        public int countBadWords(string text)
        {
          var badWordsAmount = 0;
            foreach (var word in badWords)
                if (text.Contains(word))
                    badWordsAmount = badWordsAmount + 1;
            return badWordsAmount;
        }
        public Dictionary<string, int> FindTopBadWords(string lyrics)
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in badWords)
            {
                int occurrencesOfWord = CalcOccurrenciesOf(word, lyrics);
                if (occurrencesOfWord > 0)
                    dict[word] = occurrencesOfWord;
            }
            return dict;
        }

        private int CalcOccurrenciesOf(string word, string lyrics)
        {
            return Regex.Matches(lyrics, word).Count;

        }

        static string RemoveBadWord(string text, string word)
        {
            var pattern = "\\b" + word + "\\b";
            return Regex.Replace(text, pattern, "____", RegexOptions.IgnoreCase);
           
            
        }
        public string GetBadWordsSummary(SongLyrics song)
        {
            var summary = "";
            var badWordsAmmount = FindTopBadWords(song.lyrics);
            foreach(var word in badWordsAmmount)
            {
                summary = summary + "\n" + word.Value + "-" + word.Key;
            }
            return summary;
        }
    }
}