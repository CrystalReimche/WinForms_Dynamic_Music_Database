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
    public partial class FormDeleteLastSong : Form
    {
        public FormDeleteLastSong()
        {
            InitializeComponent();
        }

        MusicContext context = new MusicContext();
        //public Albums Album { get; set; }
        public Songs Song { get; set; }

        private void FormDeleteLastSong_Load(object sender, EventArgs e)
        {
            DisplaySongs();
        }

        private void DisplaySongs()
        {
            label1.MaximumSize = new Size(250, 0);
            label1.AutoSize = true;

            //label1.Text = $"There are the following songs left in the album: ";

            dgvSongList.DataSource = (from album in context.Albums
                                      join song in context.Songs
                                      on album.AlbumId equals song.AlbumId
                                      where song.AlbumId == Song.AlbumId
                                      select new
                                      {
                                          song.SongName
                                      }).ToList();
            // format the first column
            dgvSongList.Columns[0].HeaderText = "Songs";
            dgvSongList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            BasicFormatting(dgvSongList);
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
