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
    public partial class FormSongs : Form
    {
        public FormSongs()
        {
            InitializeComponent();
        }

        readonly MusicContext context = new MusicContext();

        const int ModifyIndex = 6; // index for the Modify button column
        const int DeleteIndex = 7; // index for the Delete button column

        Artists selected_artist = null;
        Albums selected_album = null;
        Songs selected_song = null;

        private void FormSongs_Load(object sender, EventArgs e)
        {
            DisplaySongs();
        }

        private void DisplaySongs()
        {
            // get customers and bind grid
            dgvSongs.Columns.Clear();

            List<SongList> songLists = (from song in context.Songs
                                   join album in context.Albums
                                       on song.AlbumId equals album.AlbumId
                                    join artist in context.Artists
                                        on song.ArtistId equals artist.ArtistId
                                   orderby song.SongName
                                   select new SongList
                                   {
                                       Song_ID = song.SongId,
                                       Album_ID = album.AlbumId,
                                       Artist_ID = artist.ArtistId,
                                       Song = song.SongName,
                                       Album = album.AlbumName,
                                       Writer = song.WriterName
                                   }).ToList();

            SortableBindingList<SongList> sblSongs = new SortableBindingList<SongList>(songLists);
            dgvSongs.DataSource = sblSongs;

            BasicFormatting(dgvSongs);

            // format the first column
            dgvSongs.Columns[0].Visible = false;

            // format the second column
            dgvSongs.Columns[1].Visible = false;

            // format the third column
            dgvSongs.Columns[2].Visible = false;

            // format the forth column
            dgvSongs.Columns[3].HeaderText = "Song";
            dgvSongs.Columns[3].Width = 300;

            // format the fifth column
            dgvSongs.Columns[4].HeaderText = "Album";
            dgvSongs.Columns[4].Width = 200;

            // format the sixth column
            dgvSongs.Columns[5].HeaderText = "Writer(s)";
            dgvSongs.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewButtonColumn modify_column = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Edit",
                Width = 50

            };
            dgvSongs.Columns.Insert(ModifyIndex, modify_column);

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Delete",
                Width = 60
            };
            dgvSongs.Columns.Insert(DeleteIndex, delete_column);

        }

        private void dgvSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                int song_id = Convert.ToInt32(dgvSongs.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selected_song = context.Songs.Find(song_id);
            }
            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyAlbum();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteSong();
            }
        }

        private void ModifyAlbum()
        {

            var modifySongsForm = new FormSongAddModify()
            {
                AddSong = false,
                Song = selected_song,
                Artists = context.Artists.OrderBy(a => a.StageName).ToList(),
                Albums = context.Albums.OrderBy(a => a.AlbumName).ToList()
            };

            DialogResult result = modifySongsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selected_song = modifySongsForm.Song;
                context.SaveChanges();
                DisplaySongs();
            }
            else
            {
                modifySongsForm.Close();
            }

        }

        private void DeleteSong()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selected_song.SongName.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                context.Songs.Remove(selected_song);
                context.SaveChanges(true);

                var deleteLastSong = new FormDeleteLastSong()
                {
                    Song = selected_song
                };
                deleteLastSong.ShowDialog();
                DisplaySongs();
            }
        }

        private void dgvSongs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplaySingleSong(e.RowIndex);
        }

        private void DisplaySingleSong(int rowIndex)
        {
            // Get the row that was clicked
            DataGridViewRow row = dgvSongs.Rows[rowIndex];

            // Get the Song ID from that row
            int song_id = Convert.ToInt32(row.Cells[0].Value);
            // Find the song that has that ID
            selected_song = context.Songs.Find(song_id);

            // Get the Album ID from that row
            int album_id = Convert.ToInt32(row.Cells[1].Value);
            // Find the album that has that ID
            selected_album = context.Albums.Find(album_id);

            // Get the Artist ID from that row
            int artist_id = Convert.ToInt32(row.Cells[2].Value);
            // Find the artist that has that ID
            selected_artist = context.Artists.Find(artist_id);

            // Displaying Song info 
            txtSong.Text = selected_song.SongName;
            txtArtist.Text = selected_artist.StageName.ToString();
            txtAlbum.Text = selected_album.AlbumName.ToString();
            txtLength.Text = selected_song.LengthInSeconds.ToString();
            txtHighRank.Text = selected_song.HighestBillboardRanking.ToString();
            txtRankDate.Text = selected_song.DateOfBillboardRanking.ToString();
            txtWriters.Text = selected_song.WriterName;
            txtComments.Text = selected_song.Comments;
        }

        private void BasicFormatting(DataGridView grid)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 13, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(43, 43, 43);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.EnableHeadersVisualStyles = false;
            grid.DefaultCellStyle.Font = new Font("Verdana", 9);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver;
            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 239, 218);

        }
    }
}
