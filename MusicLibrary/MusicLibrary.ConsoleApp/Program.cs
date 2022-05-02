using System;
using System.Collections.Generic;
using MusicLibrary;

namespace MusicLibrary.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			Console.WriteLine("Welcome to Gold Library!");
			Console.WriteLine("------------------------\n");

            Song song1 = new Song(1, "Love Me Do", "Beatles", new TimeSpan(0, 2, 21), 1963);
            Song song2 = new Song(2, "Highway To Hell", "AC/DC", new TimeSpan(0, 3, 28), 1979);
            Song song3 = new Song(3, "Sweet Child O'Mine", "Guns N'Roses", new TimeSpan(0, 5, 21), 1987);
            Song song4 = new Song(4, "With Or Without You", "U2", new TimeSpan(0, 4, 56), 1987);
            Song song5 = new Song(5, "Crazy", "Aerosmith", new TimeSpan(0, 6, 13), 1993);
            Song song6 = new Song(6, "Zori De Zi", "Phoenix", new TimeSpan(0, 3, 44), 2005);

            MusicLibrary musicLibrary = new MusicLibrary();
            musicLibrary.AddSong(song1);
            musicLibrary.AddSong(song2);
            musicLibrary.AddSong(song3);
            musicLibrary.AddSong(song4);
            musicLibrary.AddSong(song5);
            musicLibrary.AddSong(song6);

            MusicLibrary.DisplaySongs(musicLibrary.Library);

            Console.WriteLine("\nAfter edit new list!");
            Console.WriteLine("------------------------\n");

            MusicLibrary.EditSong(musicLibrary.Library, 4, "Pita cu Unsoare", "Sandu Ciorba", new TimeSpan(0, 4, 02), 2007);
            MusicLibrary.DisplaySongs(musicLibrary.Library);

            Console.WriteLine("\nAfter delete new list!");
            Console.WriteLine("------------------------\n");

            MusicLibrary.DeleteSong(musicLibrary.Library, 6);
            MusicLibrary.DisplaySongs(musicLibrary.Library);
            Console.ReadLine();
        }
    }
}
