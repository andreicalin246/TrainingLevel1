using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Core
{
	public class Song
	{
        #region Public Properties

        public int Id { get; set; }
		public string Name { get; set; }
		public string Band { get; set; }
		public TimeSpan Duration { get; set; }
		public int YearLaunch { get; set; }

        #endregion Public Properties

        #region Constructors

        public Song(int id, string name, string band, TimeSpan duration, int year)
		{
			Id = id;
			Name = name;
			Band = band;
			Duration = duration;
			YearLaunch = year;
		}

		public Song()
		{ 
		}

		#endregion Constructors

		#region Public Methods

		public override string ToString()
		{
			return $"[{Id}]{Band} : {Name} ({YearLaunch})";
		}

		#endregion Public Methods
	}
}
