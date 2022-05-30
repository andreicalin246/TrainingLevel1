using System;
using System.Linq;

namespace MusicLibrary.Core.Services
{
    public class SongLibraryMemoryService : ISongLibraryService
	{
		#region Public Methods

		public void Populate()
		{
			var songLibrary = SongLibrary.Instance();
			var song1 = new Song(1, "Love Me Do", "Beatles", new TimeSpan(0, 2, 21), 1963);
			var song2 = new Song(2, "Highway To Hell", "AC/DC", new TimeSpan(0, 3, 28), 1979);
			var song3 = new Song(3, "Sweet Child O'Mine", "Guns N'Roses", new TimeSpan(0, 5, 21), 1987);
			var song4 = new Song(4, "With Or Without You", "U2", new TimeSpan(0, 4, 56), 1987);
			var song5 = new Song(5, "Crazy", "Aerosmith", new TimeSpan(0, 6, 13), 1993);
			var song6 = new Song(6, "Zori De Zi", "Phoenix", new TimeSpan(0, 3, 44), 2005);

			AddSong(song1);
			AddSong(song2);
			AddSong(song3);
			AddSong(song4);
			AddSong(song5);
			AddSong(song6);
		}

		public void AddSong(Song song)
		{
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Add(song);
		}

		public void DisplaySongs()
		{
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
			}
		}

		public void DisplayOneSong(int songId)
		{
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				if (songId == song.Id)
				{
					Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
				}
			}
		}

		public void EditSong(int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch)
		{
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				if (song.Id == songId)
				{
					song.Name = songName;
					song.Band = songBand;
					song.Duration = songDuration;
					song.YearLaunch = songYearLaunch;
				}
			}
		}

		public void DeleteSong(int songId)
		{
			var songLibrary = SongLibrary.Instance();
			var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
			songLibrary.Songs.Remove(songToDelete);
		}

		public void DeleteAllSongs()
		{
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Clear();
		}

		#endregion Public Methods
	}
}
