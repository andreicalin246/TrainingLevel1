using MusicLibrary.Core;
using System;
using System.Windows.Forms;

namespace MusicLibrary.DesktopApp
{
	public partial class EditForm : Form
	{
        #region Private Fields

        public Song SongEdited { get; set; }

        #endregion Private Fields

        #region Constructor

        public EditForm(Song song)
		{
			InitializeComponent();
			SongEdited = song;
		}

		#endregion Constructor

		#region Event Handlers

		private void EditForm_Load(object sender, EventArgs e)
		{
			SongName.Text = SongEdited.SongName;
			BandName.Text = SongEdited.ArtistName;
			SongYear.Text = SongEdited.YearLaunch.ToString();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			SongEdited.SongName = SongName.Text;
			SongEdited.ArtistName = BandName.Text;
			SongEdited.YearLaunch = Int32.Parse(SongYear.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();

			//MusicLibrary musicLibrary = new MusicLibrary();
			//musicLibrary.ShowDialog();

		}

		#endregion Event Handlers
  	}
}
