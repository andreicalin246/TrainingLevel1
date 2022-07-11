using MusicLibrary.Core;
using MusicLibrary.Core.Services;
using System;
using System.Windows.Forms;

namespace MusicLibrary.DesktopApp
{
	public partial class MusicLibrary : Form
    {
        #region Private Fields

        private ISongLibraryService libraryService = new SongLibraryDatabaseService();
        private SongLibrary songLibrary;

		#endregion Private Fields

		#region Methods
		public MusicLibrary()
        {
            InitializeComponent();
            songLibrary = SongLibrary.Instance();
            libraryService.Populate();
        }

		#endregion Methods

		#region Events

		private void BtnList_Click(object sender, EventArgs e)
        {
            SongList.Items.Clear();

            foreach (var song in songLibrary.Songs)
            {
                SongList.Items.Add(song);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedItem != null)
            {
                // remove from library
                var song = (Song)SongList.SelectedItem;
                libraryService.DeleteSong(song.Id);

                // remove from screen
                SongList.Items.RemoveAt(SongList.Items.IndexOf(SongList.SelectedItem));
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
		{
            if (SongList.SelectedItem != null)
            {
                var song = (Song)SongList.SelectedItem;
                EditForm editForm = new EditForm(song);
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    libraryService.EditSong(song.Id, editForm.SongEdited.Name, editForm.SongEdited.Band, song.Duration, editForm.SongEdited.YearLaunch);

                    SongList.Items.Clear();

                    foreach (var singleSong in songLibrary.Songs)
                    {
                        SongList.Items.Add(singleSong);
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var song = addForm.NewSong;
                libraryService.AddSong(song);
                SongList.Items.Add(song);
            }
            MessageBox.Show("Successfully Saved");
        }

		#endregion Events
	}
}
