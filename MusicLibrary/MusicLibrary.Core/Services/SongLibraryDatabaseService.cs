using MusicLibrary.Core.Services.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace MusicLibrary.Core.Services
{
	public class SongLibraryDatabaseService : ISongLibraryService
	{
		#region Public Methods

		public void Populate()
		{

			SqlCommand command = new SqlCommand("SELECT * FROM SONGS", SqlConnectionCreator.Instance());
			SqlDataReader reader = command.ExecuteReader();

			if (reader.HasRows)
			{
				Console.WriteLine(reader);
				var songLibrary = SongLibrary.Instance();
				while (reader.Read())
				{
					var song = new Song((int)reader["SongId"], reader["SongName"].ToString(), reader["ArtistName"].ToString(), TimeSpan.FromTicks((long)reader["SongDuration"]), (int)reader["YearLaunch"]);
					songLibrary.Songs.Add(song);
				}
			}
			reader.Close();
			
		}

		public void AddSong(Song song)
        {
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Add(song);
			SqlCommand command = new SqlCommand("INSERT INTO Songs(SongName, ArtistName, YearLaunch) VALUES('" + song.Name + "','" + song.Band + "','" + song.YearLaunch + "')", SqlConnectionCreator.Instance());
			command.ExecuteNonQuery();
			//command.CommandType = CommandType.Text;
			//command.Parameters.Add("@SongName", (SqlDbType)MySqlDbType.VarChar).Value = song.Name;
			//command.Parameters.Add("@ArtistName", (SqlDbType)MySqlDbType.VarChar).Value = song.Band;
			//command.Parameters.Add("@YearLaunch", (SqlDbType)MySqlDbType.Int32).Value = song.YearLaunch;
		}

        public void DeleteAllSongs()
        {
			var songLibrary = SongLibrary.Instance();
			songLibrary.Songs.Clear();
		}

        public void DeleteSong(int songId)
        {
			var songLibrary = SongLibrary.Instance();
			var songToDelete = songLibrary.Songs.Single(s => s.Id == songId);
			songLibrary.Songs.Remove(songToDelete);
		}

        public void DisplayOneSong(int songId)
        {
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				if (songId == song.Id)
				{
					Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
				}
			}
		}

        public void DisplaySongs()
        {
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
			{
				Console.WriteLine($"Id : {song.Id} \nSong : {song.Name} \nBand: {song.Band} \nDuration: {song.Duration} \nYearLaunch: {song.YearLaunch}\n");
			}
		}

        public void EditSong(int songId, string songName, string songBand, TimeSpan songDuration, int songYearLaunch)
        {
			var songLibrary = SongLibrary.Instance();
			foreach (Song song in songLibrary.Songs)
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

		#endregion Public Methods
	}
}
