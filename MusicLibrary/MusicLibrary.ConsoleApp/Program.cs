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

			var libraryService = new SongLibraryDatabaseService();

			var song = libraryService.Add(new Song {
				ArtistName = "B Marley",
				SongName = "Blue Tarnava",
				Duration = new TimeSpan(0, 0, 0, 1),
				YearLaunch = 1982
			});
			song = libraryService.Add(new Song
			{
				ArtistName = "Sava",
				SongName = "Blue sdsa",
				Duration = new TimeSpan(0, 0, 0, 1),
				YearLaunch = 1982
			});
			Console.WriteLine("This is one song:");
			song = libraryService.Get(3);
			song.Display();
			Console.WriteLine("------------------------\n");

			var songs = libraryService.GetAll();

			foreach (var currentSong in songs)
			{
				currentSong.Display();
			}

            Console.WriteLine("\nAfter edit new list!");
            Console.WriteLine("------------------------\n");

			var updatedSong = new Song()
			{
				Id = 2,
				SongName = "Pita cu Unsoare",
				ArtistName = "Sandu Ciorba",
				Duration = new TimeSpan(0, 4, 02),
				YearLaunch = 2007
			};

			libraryService.Update(updatedSong);
			songs = libraryService.GetAll();

			foreach (var currentSong in songs)
			{
				currentSong.Display();
			}

			Console.WriteLine("\nAfter delete new list!");
            Console.WriteLine("------------------------\n");

			libraryService.Delete(1);
			songs = libraryService.GetAll();

			foreach (var currentSong in songs)
			{
				currentSong.Display();
			}

			Console.WriteLine("The List is empty:");

			//libraryService.DeleteAll();
			songs = libraryService.GetAll();

			foreach (var currentSong in songs)
			{
				currentSong.Display();
			}

			Console.ReadLine();
        }
    }
}
