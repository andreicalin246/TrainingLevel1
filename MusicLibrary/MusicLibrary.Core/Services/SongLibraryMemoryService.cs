using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLibrary.Core.Services
{
	public class SongLibraryMemoryService : ISongLibraryService
	{
        #region Private Fields

		private static List<Song> songs = new List<Song>();

        #endregion 

        #region Public Methods

        public Song Add(Song song)
		{
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

			return song;
		}

		public List<Song> GetAll()
		{
			return songs;
		}

		public Song Get(int songId)
		{
			return songs.FirstOrDefault(s => s.Id == songId);
		}

		public bool Update(Song song)
		{
			var oldSong = Get(song.Id);

			if (oldSong != null)
			{
				oldSong.SongName = song.SongName;
				oldSong.ArtistName = song.ArtistName;
				oldSong.Duration = song.Duration;
				oldSong.YearLaunch = song.YearLaunch;

				return true;
			}

			return false;
		}

		public bool DeleteAll()
		{
			songs.Clear();
			return true;
		}

		public bool Delete(int songId)
		{
			var oldSong = Get(songId);
			if (oldSong != null)
			{
				songs.Remove(oldSong);
				return true;
			}

			return false;
		}

		#endregion Public Methods
	}
}
