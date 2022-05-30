using System;
using System.Linq;

namespace MusicLibrary.Core.Services
{
	public static class SongLibraryService
    {
        #region Public Methods

        public static void Populate(SongLibrary songLibrary)
        {
            Song song1 = new Song(1, "Love Me Do", "Beatles", new TimeSpan(0, 2, 21), 1963);
			Song song2 = new Song(2, "Highway To Hell", "AC/DC", new TimeSpan(0, 3, 28), 1979);
			Song song3 = new Song(3, "Sweet Child O'Mine", "Guns N'Roses", new TimeSpan(0, 5, 21), 1987);
			Song song4 = new Song(4, "With Or Without You", "U2", new TimeSpan(0, 4, 56), 1987);
			Song song5 = new Song(5, "Crazy", "Aerosmith", new TimeSpan(0, 6, 13), 1993);
			Song song6 = new Song(6, "Zori De Zi", "Phoenix", new TimeSpan(0, 3, 44), 2005);

			AddSong(song1, songLibrary);
			AddSong(song2, songLibrary);
			AddSong(song3, songLibrary);
			AddSong(song4, songLibrary);
			AddSong(song5, songLibrary);
			AddSong(song6, songLibrary);
		}

        // todo: move this methods in SongLibraryService

        public static void AddSong(Song song, SongLibrary songLibrary)
        {
            songLibrary.Songs.Add(song);
        }

		public static void DisplaySongs(SongLibrary songLibrary)
		{
			foreach (Song song in songLibrary.Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
			}
		}

		// todo: dispaly only one by songId

		public static void DisplayOneSong(SongLibrary songLibrary, int songId)
		{
			foreach (Song song in songLibrary.Songs)
			{
				if (songId == song.Id)
				{
					Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
				}
			}
		}

		public static void EditSong(SongLibrary songLibrary, int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch)
		{
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

		public static void DeleteSong(SongLibrary songLibrary, int songId)
		{
			var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
			songLibrary.Songs.Remove(songToDelete);
		}

		public static void DeleteAllSongs(SongLibrary songLibrary)
		{
			songLibrary.Songs.Clear();
		}
		// todo: delete all songs

		#endregion Public Methods
	}
}
