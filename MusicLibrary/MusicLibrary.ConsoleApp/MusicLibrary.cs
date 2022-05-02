using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.ConsoleApp
{
	 class MusicLibrary
	{
		public List<Song> Library { get; set; }

		public MusicLibrary()
		{
			Library = new List<Song>();
		}

		public void AddSong(Song song)
		{
			Library.Add(song);
		}

		public static void DisplaySongs(List<Song> musicLibrary)
		{
			foreach (Song song in musicLibrary)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.yearLaunch}\n");
			}
		}

		public static void EditSong(List<Song> musicLibrary, int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch)
		{
			foreach (Song song in musicLibrary)
			{
				if (song.Id == songId)
				{
					song.Name = songName;
					song.Band = songBand;
					song.Duration = songDuration;
					song.yearLaunch = songYearLaunch;
				}
			}
		}

		public static void DeleteSong(List<Song> musicLibrary, int songId)
		{
			var songToDelete = musicLibrary.Single(s => s.Id == songId);
			musicLibrary.Remove(songToDelete); 

			//foreach (Song song in musicLibrary)
			//{
			//	if (song.Id == songId)
			//	{
			//		musicLibrary.Remove(song);break;
			//	}
			//}
		}
	}
}

	
