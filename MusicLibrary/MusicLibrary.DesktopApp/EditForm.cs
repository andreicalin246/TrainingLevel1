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
	// todo: regions, nameing conventions, 
	public partial class EditForm : Form
	{
        #region Private Fields

        private Song _song { get; set; }

        #endregion Private Fields

        #region Constructor

        public EditForm(Song song)
		{
			InitializeComponent();
			_song = song;
		}

		#endregion Constructor

		#region Event Handlers

		private void EditForm_Load(object sender, EventArgs e)
		{
			songName.Text = _song.Name;
			bandName.Text = _song.Band;
			songYear.Text = _song.YearLaunch.ToString();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_song.Name = songName.Text;
			_song.Band = bandName.Text;
			_song.YearLaunch = Int32.Parse(songYear.Text);
		}

		#endregion Event Handlers
	}
}
