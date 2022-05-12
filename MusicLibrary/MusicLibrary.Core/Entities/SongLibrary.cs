using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Core
{
	public class SongLibrary
	{
		#region Private Fileds

		private static SongLibrary instance = new SongLibrary();

		#endregion Private Fields

		#region Properties

		public List<Song> Songs { get; set; }

        #endregion Properties

        #region Constructors

        private SongLibrary()
		{
			Songs = new List<Song>();
		}

		#endregion Constructors

		#region Public Methods

		public static SongLibrary Instance()
		{
			return instance;
		}
		
		// todo: move this methods in SongLibraryService

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

		public void DisplaySongs()
		{
			foreach (Song song in Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
			}
		}

        //public void DeleteAllSongs(ref List<String> Songs)
        //{
        //	List<int> itemsToRemove = new List<int>();
        //	for (int i = 0; i < Songs.Count; i++)
        //		if (i % 5 == 0)
        //			Songs.Remove(Songs[i]);
        //}
        // todo: delete all songs

        #endregion Public Methods
    }
}

	
