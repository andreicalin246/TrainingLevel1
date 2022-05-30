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
            SongLibraryService.Populate(songLibrary);

			Console.WriteLine("This is one song:");
			SongLibraryService.DisplayOneSong(songLibrary, 5);
			Console.WriteLine("------------------------\n");

			SongLibraryService.DisplaySongs(songLibrary);

            Console.WriteLine("\nAfter edit new list!");
            Console.WriteLine("------------------------\n");

			SongLibraryService.EditSong(songLibrary, 4, "Pita cu Unsoare", "Sandu Ciorba", new TimeSpan(0, 4, 02), 2007);
			SongLibraryService.DisplaySongs(songLibrary);

			Console.WriteLine("\nAfter delete new list!");
            Console.WriteLine("------------------------\n");

            SongLibraryService.DeleteSong(songLibrary, 6);
			SongLibraryService.DisplaySongs(songLibrary);

			Console.WriteLine("The List is empty:");

			SongLibraryService.DeleteAllSongs(songLibrary);
			SongLibraryService.DisplaySongs(songLibrary);
					
			// todo: songLibrary.DeleteAllSongs();

			Console.ReadLine();
        }
    }
}
