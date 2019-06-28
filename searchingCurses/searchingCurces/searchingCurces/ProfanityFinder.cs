using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace searchingCurses
{
    class ProfanityFinder
    {
        private string[] badWords;
        public ProfanityFinder()
        {
            var dictFile = File.ReadAllText("profanities.txt");
            dictFile = dictFile.Replace("*", "");
            dictFile = dictFile.Replace("(", "");
            dictFile = dictFile.Replace(")", "");
            badWords = dictFile.Split(new[] { "\",\"" }, StringSplitOptions.None);
        }
        public int countBadWords(string text)
        {
          var badWordsAmount = 0;
            foreach (var word in badWords)
                if (text.Contains(word))
                    badWordsAmount = badWordsAmount + 1;
            return badWordsAmount;
        }
    }
}