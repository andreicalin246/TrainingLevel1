using System;
using System.Collections.Generic;
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

		public Song Add(Song song)
		{
			var songs = GetAll();
			var lastSong = songs.LastOrDefault();
			if (lastSong == null)
			{
				song.Id = 1;
			}
			else
			{
				song.Id = lastSong.Id + 1;
			}

			var fileStream = File.Open(SongLibraryFileName, FileMode.Append);
			var streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine(song.Id);
			streamWriter.WriteLine(song.SongName);
			streamWriter.WriteLine(song.ArtistName);
			streamWriter.WriteLine(song.Duration);
			streamWriter.WriteLine(song.YearLaunch);
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();

			return song;
		}

		public List<Song> GetAll()
		{
			var songs = new List<Song>();

			var fileStream = File.Open(SongLibraryFileName, FileMode.Open);
			var streamReader = new StreamReader(fileStream);
			string id = null;

			do
			{
				id = streamReader.ReadLine();
				var songName = streamReader.ReadLine();
				var artistName = streamReader.ReadLine();
				var duration = streamReader.ReadLine();
				var yearLaunch = streamReader.ReadLine();

				if (id != null)
				{
					var song = new Song();
					song.Id = int.Parse(id);
					song.SongName = songName;
					song.ArtistName = artistName;
					song.Duration = TimeSpan.FromTicks(long.Parse(duration));
					song.YearLaunch = int.Parse(yearLaunch);
				}
			}
			while (id != null);

			streamReader.Close();
			fileStream.Close();

			return songs;
		}

		public Song Get(int songId)
		{
			var fileStream = File.Open(SongLibraryFileName, FileMode.Open);
			var streamReader = new StreamReader(fileStream);
			string id = null;

			do
			{
				id = streamReader.ReadLine();
				var songName = streamReader.ReadLine();
				var artistName = streamReader.ReadLine();
				var duration = streamReader.ReadLine();
				var yearLaunch = streamReader.ReadLine();

				if (id != null && id == songId.ToString())
				{
					var song = new Song();
					song.Id = int.Parse(id);
					song.SongName = songName;
					song.ArtistName = artistName;
					song.Duration = TimeSpan.FromTicks(long.Parse(duration));
					song.YearLaunch = int.Parse(yearLaunch);

					return song;
				}
			}
			while (id != null);

			streamReader.Close();
			fileStream.Close();

			return null;
		}

		public bool Update(Song song)
		{
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				if (song.Id == songId)
				{
					song.SongName = songName;
					song.ArtistName = songBand;
					song.Duration = songDuration;
					song.YearLaunch = songYearLaunch;
				}
			}
		}

		public bool DeleteAll()
		{
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Clear();
		}

		public bool Delete(int songId)
		{
			var songLibrary = SongLibrary.Instance();
			var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
			songLibrary.Songs.Remove(songToDelete);
		}

		#endregion Public Methods
	}
}
