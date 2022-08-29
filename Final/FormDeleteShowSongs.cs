using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Final.Models.DataLayer;

namespace Final
{
    public partial class FormDeleteShowSongs : Form
    {
        public FormDeleteShowSongs()
        {
            InitializeComponent();
        }

        MusicContext context = new MusicContext();
        public Albums Album { get; set; }

        private void FormDeleteShowSongs_Load(object sender, EventArgs e)
        {
            DisplaySongs();
        }

        private void DisplaySongs()
        {
            lblSongList.MaximumSize = new Size(240, 0);
            lblSongList.AutoSize = true;

            lblSongList.Text = $"By deleting {Album.AlbumName}, you will also be deleting the following songs: ";

            dgvDeletedSongs.DataSource = (from album in context.Albums
                                          join song in context.Songs
                                          on album.AlbumId equals song.AlbumId
                                          where album.AlbumId == Album.AlbumId
                                          select new
                                          {
                                              song.SongName
                                          }).ToList();
            // format the first column
            dgvDeletedSongs.Columns[0].HeaderText = "Songs";
            dgvDeletedSongs.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            BasicFormatting(dgvDeletedSongs);
        }

        private void BasicFormatting(DataGridView grid)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 43, 43);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.DefaultCellStyle.Font = new Font("Verdana", 9);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 239, 218);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
