using MusicLibrary.Core;
using MusicLibrary.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// todo: remove and sort the usings (right click->Remove and sort)

namespace MusicLibrary.DesktopApp
{
    // todo: renamethe form
    public partial class Form1 : Form
    {
        #region Private Fields

        private SongLibrary songLibrary;

        #endregion Private Fields

        // todo: regions
        public Form1()
        {
            InitializeComponent();
            songLibrary = SongLibrary.Instance();
            SongLibraryService.Populate();
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedItem != null)
            {
                // remove from library
                var song = (Song)SongList.SelectedItem;
                SongLibraryService.DeleteSong(song.Id);

                // remove from screen
                SongList.Items.RemoveAt(SongList.Items.IndexOf(SongList.SelectedItem));
            }
        }

        // todo: rename the method (start with upper letter)
        // todo: rename button2
        private void button2_Click(object sender, EventArgs e)
		{
            if (SongList.SelectedItem != null)
            {
                var song = (Song)SongList.SelectedItem;
                EditForm editForm = new EditForm(song);
                editForm.ShowDialog();
            }
        }

		#endregion Events

        // todo: remove this events
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
