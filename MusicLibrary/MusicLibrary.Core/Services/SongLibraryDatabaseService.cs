using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace MusicLibrary.Core.Services
{
    public class SongLibraryDatabaseService : ISongLibraryService
    {
		#region Private Fields

		private const string SongLibraryConnectionString = "ServerName: Database: Trusted:";

		#endregion Private Fields

		#region Public Methods

		public void AddSong(Song song)
        {
			// todo
		}

        public void DeleteAllSongs()
        {
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Clear();
		}

        public void DeleteSong(int songId)
        {
			var songLibrary = SongLibrary.Instance();
			var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
			songLibrary.Songs.Remove(songToDelete);
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

        public void DisplaySongs()
        {
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
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

        public void Populate()
        {
			// todo
		}

		#endregion Public Methods
	}
}
