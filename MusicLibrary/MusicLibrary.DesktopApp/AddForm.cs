using MusicLibrary.Core;
using System;
using System.Windows.Forms;

namespace MusicLibrary.DesktopApp
{
	public partial class AddForm : Form
	{

		#region Private Fields

		public Song SongAdd { get; set; }

		#endregion Private Fields

		#region constructor
		public AddForm(Song song)
		{
			InitializeComponent();
			SongAdd = song;
		}

		#endregion Constructor

		#region Event Handlers


		private void AddForm_Load(object sender, EventArgs e)
		{
			AddedSongName.Text = SongAdd.Name;
			AddedBandName.Text = SongAdd.Band;
			AddedSongYear.Text = SongAdd.YearLaunch.ToString();	
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			SongAdd.Name = AddedSongName.Text;
			SongAdd.Band = AddedBandName.Text;
			SongAdd.YearLaunch = Int32.Parse(AddedSongYear.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		#endregion Event Handlers

	}
}
