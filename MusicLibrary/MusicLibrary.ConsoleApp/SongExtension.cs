using MusicLibrary.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.ConsoleApp
{
    internal static class SongExtension
    {
        public static void Display(this Song song)
        {
            Console.WriteLine("------------------");
            Console.WriteLine(song.Id);
            Console.WriteLine(song.ArtistName);
            Console.WriteLine(song.SongName);
            Console.WriteLine(song.Duration);
            Console.WriteLine(song.YearLaunch);
            Console.WriteLine("------------------");
        }
    }
}
