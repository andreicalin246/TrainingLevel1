using MusicLibrary.Core;
using MusicLibrary.Core.Services;
using System;
using System.Collections.Generic;
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
        }

        #endregion Methods

        #region Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var song = addForm.NewSong;
                libraryService.Add(song);
                SongList.Items.Add(song);
            }
            PopulateMusicLibrary();
            MessageBox.Show("Successfully Saved");
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            PopulateMusicLibrary();
        }

        private void BtnListOne_Click(object sender, EventArgs e)
        {

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
                    libraryService.Update(editForm.SongEdited);                     
                }
                PopulateMusicLibrary();
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedItem != null)
            {
                // remove from library
                var song = (Song)SongList.SelectedItem;
                libraryService.Delete(song.Id);

                // remove from screen
                SongList.Items.RemoveAt(SongList.Items.IndexOf(SongList.SelectedItem));
            }
        }

        private void BtnDeleteAll_Click(object sender, EventArgs e)
        {
            SongList.Items.Clear();
        }

        #region Private Methods
        private void PopulateMusicLibrary()
        {
            SongList.Items.Clear();
            var songs = libraryService.GetAll();
            foreach (var song in songs)
            {
                SongList.Items.Add(song);
            }
        }
        #endregion Private Methods
    }

    #endregion Events



}