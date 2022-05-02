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
                listBox1.Items.Add(song);
            }
        }

        #endregion Events
    }
}
