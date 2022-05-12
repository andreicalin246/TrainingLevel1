using MusicLibrary.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary.DesktopApp
{
	public partial class EditForm : Form
	{
		public Song Song { get; set; }

		public EditForm()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void EditForm_Load(object sender, EventArgs e)
		{
			songName.Text = Song.Name;
			bandName.Text = Song.Band;
			songYear.Text = Song.YearLaunch.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Song.Name = songName.Text;
			Song.Band = bandName.Text;
			Song.YearLaunch = Int32.Parse(songYear.Text);

			//songLibrary.EditSong(Song.Id, Song.Name, Song.Band, Song.Duration, Song.YearLaunch);

		}
	}
}
