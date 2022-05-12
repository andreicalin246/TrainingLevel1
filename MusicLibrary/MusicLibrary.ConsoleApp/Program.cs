using System;
using System.Collections.Generic;
using MusicLibrary;
using MusicLibrary.Core;
using MusicLibrary.Core.Services;

namespace MusicLibrary.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.WriteLine("Welcome to Gold Library!");
			Console.WriteLine("------------------------\n");

            var songLibrary = SongLibrary.Instance();
            SongLibraryService.Populate();

            songLibrary.DisplaySongs();

            Console.WriteLine("\nAfter edit new list!");
            Console.WriteLine("------------------------\n");

            songLibrary.EditSong(4, "Pita cu Unsoare", "Sandu Ciorba", new TimeSpan(0, 4, 02), 2007);
            songLibrary.DisplaySongs();

            Console.WriteLine("\nAfter delete new list!");
            Console.WriteLine("------------------------\n");

            SongLibraryService.DeleteSong(6);
            songLibrary.DisplaySongs();

			// todo: songLibrary.DeleteAllSongs();

            Console.ReadLine();
        }
    }
}
