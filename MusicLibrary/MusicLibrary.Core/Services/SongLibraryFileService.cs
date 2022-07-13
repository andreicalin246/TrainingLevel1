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
			streamWriter.WriteLine(song.Duration.Ticks);
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

					songs.Add(song);
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
					streamReader.Close();
					fileStream.Close();

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
			var songs = GetAll();
			var oldSong = songs.FirstOrDefault(x => x.Id == song.Id);

			if (oldSong != null)
			{
				oldSong.SongName = song.SongName;
				oldSong.ArtistName = song.ArtistName;
				oldSong.Duration = song.Duration;
				oldSong.YearLaunch = song.YearLaunch;

				WriteSongs(songs);

				return true;
			}

			return false;
		}

		public bool DeleteAll()
		{
			var fileStream = File.Open(SongLibraryFileName, FileMode.Open);
			fileStream.SetLength(0);
			fileStream.Close();
			return true;
		}

		public bool Delete(int songId)
		{
			var songs = GetAll();
			var oldSong = songs.FirstOrDefault(x => x.Id == songId);

			if (oldSong != null)
			{
				songs.Remove(oldSong);
				WriteSongs(songs);

				return true;
			}

			return false;
		}

		#endregion Public Methods

		#region Private Methods

		private static void WriteSongs(List<Song> songs)
		{
			var fileStream = File.Open(SongLibraryFileName, FileMode.Create);
			var streamWriter = new StreamWriter(fileStream);

			foreach (var currentSong in songs)
			{
				streamWriter.WriteLine(currentSong.Id);
				streamWriter.WriteLine(currentSong.SongName);
				streamWriter.WriteLine(currentSong.ArtistName);
				streamWriter.WriteLine(currentSong.Duration.Ticks);
				streamWriter.WriteLine(currentSong.YearLaunch);
			}

			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
		}

		#endregion Private Methods
	}
}
