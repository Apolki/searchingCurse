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
            Console.WriteLine("Dla jakiego artysty chcesz poznać statystyki?");
            var artists = Console.ReadLine();
            var artist = new Artist(artists);
            Console.WriteLine("Podaj tytuły jego piosenek, każdy w jednej linii. Pusta linia to koniec wczytywania. (Zaczynając od drugiego tworu przed nazwą pisać spacje)");
            artist.songTitles = new List<string>();
            do
                artist.songTitles.Add(Console.ReadLine());
            while (Console.ReadKey().Key != ConsoleKey.Enter);
             artist.CalculateSwearAndWordCount();
             artist.DisplayStatistics();            
            Console.WriteLine("Done");
            Console.ReadLine();
            
        }
    }
   
}
            
            
                
