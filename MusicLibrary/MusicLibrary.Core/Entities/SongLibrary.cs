using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Core
{
	public class SongLibrary
	{
        #region Properties

        public List<Song> Songs { get; set; }

        #endregion Properties

        #region Constructors

        public SongLibrary()
		{
			Songs = new List<Song>();
		}

        #endregion Constructors

        // todo: move this methods in SongLibraryService

        #region Public Methods

        public void AddSong(Song song)
		{
			Songs.Add(song);
		}

		// todo: dispaly only one by songId

		public void EditSong(int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch)
		{
			foreach (Song song in Songs)
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
			var songToDelete = Songs.Single(s => s.Id == songId);
			Songs.Remove(songToDelete); 
		}

		public void DisplaySongs()
		{
			foreach (Song song in Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
			}
		}

		// todo: delete all songs

		#endregion Public Methods
	}
}

	
