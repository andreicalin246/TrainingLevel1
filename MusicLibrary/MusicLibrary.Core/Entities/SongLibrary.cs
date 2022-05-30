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
		
        #endregion Public Methods
    }
}

	
