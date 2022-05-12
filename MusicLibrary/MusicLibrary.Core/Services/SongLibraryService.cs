using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Core.Services
{
    public static class SongLibraryService
    {
        #region Public Methods

        public static void Populate()
        {
            SongLibrary songLibrary = SongLibrary.Instance();
            Song song1 = new Song(1, "Love Me Do", "Beatles", new TimeSpan(0, 2, 21), 1963);
            Song song2 = new Song(2, "Highway To Hell", "AC/DC", new TimeSpan(0, 3, 28), 1979);
            Song song3 = new Song(3, "Sweet Child O'Mine", "Guns N'Roses", new TimeSpan(0, 5, 21), 1987);
            Song song4 = new Song(4, "With Or Without You", "U2", new TimeSpan(0, 4, 56), 1987);
            Song song5 = new Song(5, "Crazy", "Aerosmith", new TimeSpan(0, 6, 13), 1993);
            Song song6 = new Song(6, "Zori De Zi", "Phoenix", new TimeSpan(0, 3, 44), 2005);

            songLibrary.AddSong(song1);
            songLibrary.AddSong(song2);
            songLibrary.AddSong(song3);
            songLibrary.AddSong(song4);
            songLibrary.AddSong(song5);
            songLibrary.AddSong(song6);
        }

        public static void DeleteSong(int songId)
        {
            SongLibrary songLibrary = SongLibrary.Instance();
            var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
            songLibrary.Songs.Remove(songToDelete);
        }

        #endregion Public Methods
    }
}
