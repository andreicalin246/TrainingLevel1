using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;

namespace MusicLibrary.Core.Services
{
	public class SongLibraryJsonService : ISongLibraryService
    {
		#region Private Fields

		private const string SongLibraryFileName = "Library.json";

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

			songs.Add(song);
			WriteSongs(songs);

			return song;
		}

		public List<Song> GetAll()
		{
			string json = File.ReadAllText(SongLibraryFileName);

			var songs = new List<Song>();
			try
			{
				songs = JsonSerializer.Deserialize<List<Song>>(json);
			}
			catch (Exception ex)
			{ 
			}

			return songs;
		}

		public Song Get(int songId)
		{
			var songs = GetAll();
			return songs.FirstOrDefault(x => x.Id == songId);
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
			string json = JsonSerializer.Serialize(songs);
			File.WriteAllText(SongLibraryFileName, json);
		}

		#endregion Private Methods
	}
}
