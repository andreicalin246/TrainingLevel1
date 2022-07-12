using MusicLibrary.Core;
using System;
using System.Windows.Forms;

namespace MusicLibrary.DesktopApp
{
	public partial class AddForm : Form
	{
		#region Private Fields

		public Song NewSong { get; private set; }

		#endregion Private Fields

		#region Constructor

		public AddForm()
		{
			InitializeComponent();
			NewSong = new Song();
		}

		#endregion Constructor

        #region Event Handlers

        private void AddForm_Load(object sender, EventArgs e)
		{
			AddedSongName.Text = "";
			AddedBandName.Text = "";
			AddedSongYear.Text = "";	
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			NewSong.SongName = AddedSongName.Text;
			NewSong.ArtistName = AddedBandName.Text;
			NewSong.YearLaunch = Int32.Parse(AddedSongYear.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		#endregion Event Handlers

	}
}
