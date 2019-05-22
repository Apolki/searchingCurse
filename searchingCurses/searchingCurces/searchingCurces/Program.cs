using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Console.WriteLine("title = ");
            string title = Console.ReadLine();
            var songsLyrics = new SongLyrics(artist, title);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

  class SongLyrics
    {
        public SongLyrics(string artist, string title)
        {
            var browser = new WebClient();
            var url = "https://api.lyrics.ovh/v1/" + artist + "/" + title;
            var json = browser.DownloadString(url);
            Console.WriteLine(json);
        }
    }
}
