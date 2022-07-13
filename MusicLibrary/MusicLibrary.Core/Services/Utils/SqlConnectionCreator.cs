using System;
using System.Data.SqlClient;

namespace MusicLibrary.Core.Services.Utils
{
	public sealed class SqlConnectionCreator
	{
		private const string SongLibraryConnectionString = "Server=ANDREICALIN-PC\\SQLEXPRESS;  Database=MusicLibrary; Trusted_Connection=true";
		private static readonly Lazy<SqlConnection> instance = new Lazy<SqlConnection>(new SqlConnection(SongLibraryConnectionString));

		private SqlConnectionCreator()
		{
		}

		public static SqlConnection Instance()
		{
			var obj = instance.Value;
			if (obj.State != System.Data.ConnectionState.Open)
			{
				obj.Open();
			}

			return obj;
		}
	}
}
