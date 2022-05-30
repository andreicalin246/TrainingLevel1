using MusicLibrary.Core;
using System;
using System.Windows.Forms;

namespace MusicLibrary.DesktopApp
{
	// todo: regions, nameing conventions, 
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
			SongName.Text = SongEdited.Name;
			BandName.Text = SongEdited.Band;
			SongYear.Text = SongEdited.YearLaunch.ToString();
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			SongEdited.Name = SongName.Text;
			SongEdited.Band = BandName.Text;
			SongEdited.YearLaunch = Int32.Parse(SongYear.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();

			//MusicLibrary musicLibrary = new MusicLibrary();
			//musicLibrary.ShowDialog();

		}

		#endregion Event Handlers
  	}
}
