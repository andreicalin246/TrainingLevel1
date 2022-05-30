using System;

namespace MusicLibrary.Core.Services
{
    public interface ISongLibraryService
	{
		void Populate();

		void AddSong(Song song);

		void DisplaySongs();

		void DisplayOneSong(int songId);

		void EditSong(int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch);

		void DeleteSong(int songId);

		void DeleteAllSongs();
	}
}
