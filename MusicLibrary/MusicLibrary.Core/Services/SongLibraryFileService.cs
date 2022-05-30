using System;
using System.IO;
using System.Linq;

namespace MusicLibrary.Core.Services
{
    public class SongLibraryFileService : ISongLibraryService
	{
		#region Private Fields

		private const string SongLibraryFileName = "Library.txt";

		#endregion Private Fields

		#region Public Methods

		public void Populate()
		{
			var songLibrary = SongLibrary.Instance();
			var lines = File.ReadAllLines(SongLibraryFileName);

			foreach (var line in lines)
			{
				var values = line.Split(',');
				var songId = int.Parse(values[0]);
				var songName = values[1];
				var songArtiste = values[2];
				var songDuration = TimeSpan.Parse(values[3]);
				var songYear = int.Parse(values[4]);

				var song = new Song(songId, songName, songArtiste, songDuration, songYear);
				songLibrary.Songs.Add(song);
			}
		}

		public void AddSong(Song song)
		{
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Add(song);
			var fileStream = File.Open(SongLibraryFileName, FileMode.Append);
			var streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("mama are mere");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
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
