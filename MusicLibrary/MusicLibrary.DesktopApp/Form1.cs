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

namespace MusicLibrary.DesktopApp
{
    public partial class Form1 : Form
    {
        // todo: regions
        public Form1()
        {
            InitializeComponent();
        }

        #region Events

        private void BtnList_Click(object sender, EventArgs e)
        {
            var songLibrary = new SongLibrary();
            SongLibraryService.Populate(songLibrary);

            foreach (var song in songLibrary.Songs)
            {
                SongList.Items.Add(song);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SongList.SelectedItem != null)
            {
                SongList.Items.RemoveAt(SongList.Items.IndexOf(SongList.SelectedItem));
            }
        }


		private void button2_Click(object sender, EventArgs e)
		{
            if (SongList.SelectedItem != null)
            {
                EditForm editForm = new EditForm();
                editForm.Song = (Song)SongList.SelectedItem;
                editForm.ShowDialog();
            }
        }

		#endregion Events

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
