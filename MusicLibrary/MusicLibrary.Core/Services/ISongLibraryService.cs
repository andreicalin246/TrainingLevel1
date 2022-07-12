using System;
using System.Collections.Generic;

namespace MusicLibrary.Core.Services
{
    public interface ISongLibraryService
	{
		Song Add(Song song);

		List<Song> GetAll();

		Song Get(int songId);

		bool Update(Song song);

		bool Delete(int songId);

		bool DeleteAll();
	}
}
