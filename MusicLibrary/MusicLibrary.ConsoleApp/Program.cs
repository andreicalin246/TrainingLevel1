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
			libraryService.Get(5);
			Console.WriteLine("------------------------\n");

			libraryService.GetAll();

            Console.WriteLine("\nAfter edit new list!");
            Console.WriteLine("------------------------\n");

			libraryService.EditSong(4, "Pita cu Unsoare", "Sandu Ciorba", new TimeSpan(0, 4, 02), 2007);
			libraryService.GetAll();

			Console.WriteLine("\nAfter delete new list!");
            Console.WriteLine("------------------------\n");

			libraryService.Delete(6);
			libraryService.GetAll();

			Console.WriteLine("The List is empty:");

			libraryService.DeleteAllSongs();
			libraryService.GetAll();
					
			Console.ReadLine();
        }
    }
}
