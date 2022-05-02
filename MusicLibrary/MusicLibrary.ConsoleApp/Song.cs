using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.ConsoleApp
{
	class Song
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Band { get; set; }
		public TimeSpan Duration { get; set; }
		public int yearLaunch { get; set; }

		public Song(int id, string name, string band, TimeSpan duration, int year)
		{
			Id = id;
			Name = name;
			Band = band;
			Duration = duration;
			yearLaunch = year;
		}

		public Song()
		{ 
		}
	}
}
