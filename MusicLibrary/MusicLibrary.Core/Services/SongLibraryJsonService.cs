﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace MusicLibrary.Core.Services
{
	// todo: rewrite this class
	public class SongLibraryJsonService : ISongLibraryService
    {
		#region Private Fields

		private const string SongLibraryFileName = "Library.xml";

		#endregion Private Fields

		#region Public Methods

		public void Add(Song song)
        {
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Add(song);
			var fileStream = File.Open(SongLibraryFileName, FileMode.Truncate);
			var streamWriter = new StreamWriter(fileStream);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Song>));
			xmlSerializer.Serialize(streamWriter, songLibrary.Songs);
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
		}

        public void DeleteAllSongs()
        {
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Clear();
		}

        public void Delete(int songId)
        {
			var songLibrary = SongLibrary.Instance();
			var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
			songLibrary.Songs.Remove(songToDelete);
		}

        public void Get(int songId)
        {
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				if (songId == song.Id)
				{
					Console.WriteLine($"Id : {song.Id} \nSong : {song.SongName} \nBand: {song.ArtistName} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
				}
			}
		}

        public void GetAll()
        {
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.SongName} \nBand: {song.ArtistName} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
			}
		}

        public void EditSong(int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch)
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

        public void Populate()
        {
			var songLibrary = SongLibrary.Instance();
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Song>));

			using (var fileStream = File.OpenRead(SongLibraryFileName))
			{
				var songs = (List<Song>)xmlSerializer.Deserialize(fileStream);
				songLibrary.Songs.AddRange(songs);
			}
		}

		#endregion Public Methods
	}
}