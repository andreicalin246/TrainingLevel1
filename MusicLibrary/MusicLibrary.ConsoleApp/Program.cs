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

			var libraryService = new SongLibraryMemoryService();
            var songLibrary = SongLibrary.Instance();
			libraryService.Populate();

			Console.WriteLine("This is one song:");
			libraryService.DisplayOneSong(5);
			Console.WriteLine("------------------------\n");

			libraryService.DisplaySongs();

            Console.WriteLine("\nAfter edit new list!");
            Console.WriteLine("------------------------\n");

			libraryService.EditSong(4, "Pita cu Unsoare", "Sandu Ciorba", new TimeSpan(0, 4, 02), 2007);
			libraryService.DisplaySongs();

			Console.WriteLine("\nAfter delete new list!");
            Console.WriteLine("------------------------\n");

			libraryService.DeleteSong(6);
			libraryService.DisplaySongs();

			Console.WriteLine("The List is empty:");

			libraryService.DeleteAllSongs();
			libraryService.DisplaySongs();
					
			Console.ReadLine();
        }
    }
}
