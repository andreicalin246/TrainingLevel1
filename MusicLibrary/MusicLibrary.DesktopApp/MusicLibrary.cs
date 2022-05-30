using MusicLibrary.Core;
using MusicLibrary.Core.Services;
using System;
using System.Windows.Forms;

// todo: remove and sort the usings (right click->Remove and sort)

namespace MusicLibrary.DesktopApp
{
	// todo: renamethe form
	public partial class MusicLibrary : Form
    {
        #region Private Fields

        private SongLibrary songLibrary;

		#endregion Private Fields

		// todo: regions

		#region Methods
		public MusicLibrary()
        {
            InitializeComponent();
            songLibrary = SongLibrary.Instance();
            SongLibraryService.Populate(songLibrary);
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

        // todo: rename the method (start with upper letter)
        // todo: rename button1
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedItem != null)
            {
                // remove from library
                var song = (Song)SongList.SelectedItem;
                SongLibraryService.DeleteSong(songLibrary, song.Id);

                // remove from screen
                SongList.Items.RemoveAt(SongList.Items.IndexOf(SongList.SelectedItem));
            }
        }

        // todo: rename the method (start with upper letter)
        // todo: rename button2
        private void BtnEdit_Click(object sender, EventArgs e)
		{
            if (SongList.SelectedItem != null)
            {
                var song = (Song)SongList.SelectedItem;
                EditForm editForm = new EditForm(song);
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    SongLibraryService.EditSong(songLibrary, song.Id, editForm.SongEdited.Name, editForm.SongEdited.Band, song.Duration, editForm.SongEdited.YearLaunch);

                    SongList.Items.Clear();

                    foreach (var singleSong in songLibrary.Songs)
                    {
                        SongList.Items.Add(singleSong);
                    }
                }
            }
        }

		//private void BtnAdd_Click(object sender, EventArgs e)
		//{
  //          if (SongList.SelectedItem != null)
  //          {
  //              var song = (Song)SongList.SelectedItem;
  //              AddForm addForm = new AddForm(song);
  //              var result = addForm.ShowDialog();
  //              if (result == DialogResult.OK)
  //              {
  //                  SongLibraryService.AddSong(song, songLibrary);
  //                  SongList.Items.Clear();
  //                  foreach (var singleSong in songLibrary.Songs)
  //                  {
  //                      SongList.Items.Add(singleSong);
  //                  }
  //            }

  //       }

		

		#endregion Events

		// todo: remove this events
	}
}
