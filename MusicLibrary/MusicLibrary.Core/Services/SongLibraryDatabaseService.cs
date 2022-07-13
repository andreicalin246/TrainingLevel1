using MusicLibrary.Core.Services.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MusicLibrary.Core.Services
{
    public class SongLibraryDatabaseService : ISongLibraryService
	{
		#region Public Methods

		public Song Add(Song song)
        {
			var sqlConnection = SqlConnectionCreator.Instance();
			var query = $@"
				INSERT INTO Songs
					(SongName, ArtistName, YearLaunch, Duration) 
				VALUES
					(@SongName, @ArtistName, @YearLaunch, @Duration)

				SELECT SCOPE_IDENTITY()";

			using (SqlCommand command = new SqlCommand(query, sqlConnection))
			{
				command.Parameters.Add(new SqlParameter("@SongName", song.SongName));
				command.Parameters.Add(new SqlParameter("@ArtistName", song.ArtistName));
				command.Parameters.Add(new SqlParameter("@YearLaunch", song.YearLaunch));
				command.Parameters.Add(new SqlParameter("@Duration", song.Duration.Ticks));

				var sqlReader = command.ExecuteReader();
				sqlReader.Read();
				var id = Decimal.ToInt32((decimal)sqlReader[0]);
				song.Id = id;
				sqlReader.Close();


				return song;
			}
		}

		public List<Song> GetAll()
		{
			var sqlConnection = SqlConnectionCreator.Instance();
			var query = @"
				SELECT * 
				FROM Songs";

			using (SqlCommand command = new SqlCommand(query, sqlConnection))
			{
				var songs = new List<Song>();

				var sqlReader = command.ExecuteReader();

				while (sqlReader.Read())
				{
					var song = new Song();
					song.Id = (int)sqlReader["SongId"];
					song.SongName = (string)sqlReader["SongName"];
					song.ArtistName = (string)sqlReader["ArtistName"];
					song.YearLaunch = (int)sqlReader["YearLaunch"];
					song.Duration = TimeSpan.FromTicks((long)sqlReader["Duration"]);

					songs.Add(song);
				}

				sqlReader.Close();

				return songs;
			}
		}

		public Song Get(int songId)
		{
			var sqlConnection = SqlConnectionCreator.Instance();
			var query = $@"
				SELECT * 
				FROM Songs
				WHERE SongId = {songId}";

			using (SqlCommand command = new SqlCommand(query, sqlConnection))
			{
				Song song = null;
				var sqlReader = command.ExecuteReader();

				while (sqlReader.Read())
				{
					song = new Song();
					song.Id = (int)sqlReader["SongId"];
					song.SongName = (string)sqlReader["SongName"];
					song.ArtistName = (string)sqlReader["ArtistName"];
					song.YearLaunch = (int)sqlReader["YearLaunch"];
					song.Duration = TimeSpan.FromTicks((long)sqlReader["Duration"]);
				}

				sqlReader.Close();

				return song;
			}
		}

		public bool Update(Song song)
		{
			var sqlConnection = SqlConnectionCreator.Instance();
			var query = $@"
				UPDATE Songs
				SET SongName = @SongName,
					ArtistName = @ArtistName,
					Duration = @Duration,
					YearLaunch = @YearLaunch
				WHERE SongId = {song.Id}
				";

			using (SqlCommand command = new SqlCommand(query, sqlConnection))
			{
				command.Parameters.Add(new SqlParameter("@SongName", song.SongName));
				command.Parameters.Add(new SqlParameter("@ArtistName", song.ArtistName));
				command.Parameters.Add(new SqlParameter("@YearLaunch", song.YearLaunch));
				command.Parameters.Add(new SqlParameter("@Duration", song.Duration.Ticks));

				var result = command.ExecuteNonQuery();
				return result > 0;
			}
		}

		public bool DeleteAll()
        {
			var sqlConnection = SqlConnectionCreator.Instance();
			var query = $@"
				DELETE Songs";

			using (SqlCommand command = new SqlCommand(query, sqlConnection))
			{
				var result = command.ExecuteNonQuery();
				return result > 0;
			}
		}

        public bool Delete(int songId)
        {
			var sqlConnection = SqlConnectionCreator.Instance();
			var query = $@"
				DELETE Songs
				WHERE SongId = {songId}
				";

			using (SqlCommand command = new SqlCommand(query, sqlConnection))
			{
				var result = command.ExecuteNonQuery();
				return result > 0;
			}
		}

		#endregion Public Methods
	}
}
