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
    public partial class FormArtists : Form
    {
        public FormArtists()
        {
            InitializeComponent();
        }

        readonly MusicContext context = new MusicContext();

        const int ModifyIndex = 4; // index for the Modify button column
        const int DeleteIndex = 5; // index for the Delete button column

        readonly char[] space = new char[] { ' ' };

        Artists selected_artist = null;
        Songs selected_song = null;
        Albums selected_album = null;

        private void FormArtists_Load(object sender, EventArgs e)
        {
            DisplayArtists();
        }

        private void DisplayArtists()
        {
            dgvArtists.Columns.Clear();

            List<ArtistList> artistLists = (from a in context.Artists
                                            orderby a.BirthName
                                            select new ArtistList
                                            {
                                                ArtistID = a.ArtistId,
                                                Last_Name = a.BirthName.Split(space).Last(),
                                                Age = a.DateOfDeath.HasValue ?
                                                   (Convert.ToDateTime(a.DateOfDeath).Year - a.DateOfBirth.Year) :
                                                   (DateTime.Today.Year - a.DateOfBirth.Year),
                                                Song_Count = a.Songs.Count
                                            })
                                            // .OrderBy(a => a.Last_Name)
                                            .ToList();

            SortableBindingList<ArtistList> sblArtists = new SortableBindingList<ArtistList>(artistLists);
            dgvArtists.DataSource = sblArtists;

            // format basic grid
            BasicFormatting(dgvArtists);

            // format the first column
            dgvArtists.Columns[0].Visible = false;

            // format the second column
            dgvArtists.Columns[1].HeaderText = "Birth Name";
            dgvArtists.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // format the third column
            dgvArtists.Columns[2].HeaderText = "Age";
            dgvArtists.Columns[2].Width = 110;
            //dgvArtists.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // format the forth column
            dgvArtists.Columns[3].HeaderText = "Songs";
            dgvArtists.Columns[3].Width = 110;
            //dgvArtists.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            DataGridViewButtonColumn modify_column = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Edit",
                Width = 50
            };
            dgvArtists.Columns.Insert(ModifyIndex, modify_column);

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Delete",
                Width = 60
            };
            dgvArtists.Columns.Insert(DeleteIndex, delete_column);
        }

        private void dgvArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                int artist_id = Convert.ToInt32(dgvArtists.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selected_artist = context.Artists.Find(artist_id);
            }
            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyArtist();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteArtist();
            }
        }

        private void ModifyArtist()
        {
            var modifyForm = new FormArtistAddModify()
            {
                AddArtist = false,
                Artist = selected_artist
            };
            DialogResult result = modifyForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selected_artist = modifyForm.Artist;
                context.SaveChanges();
                DisplayArtists();
            }
            else
            {
                modifyForm.Close();
            }
        }

        private void DeleteArtist()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selected_artist.BirthName.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                context.Artists.Remove(selected_artist);
                context.SaveChanges(true);
                DisplayArtists();
            }
        }

        private void dgvArtists_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayIndivArtist(e.RowIndex);
            DisplaySongsList(e.RowIndex);
        }

        private void DisplayIndivArtist(int rowIndex)
        {
            // Get the row that was clicked
            DataGridViewRow row = dgvArtists.Rows[rowIndex];
            // Get the Artist ID from that row
            int artist_id = Convert.ToInt32(row.Cells[0].Value);
            // Find the artist that has that ID
            selected_artist = context.Artists.Find(artist_id);

            // Displaying Artist info 
            txtStageName.Text = selected_artist.StageName.ToString();
            txtBirthName.Text = selected_artist.BirthName.ToString();
            txtDOB.Text = selected_artist.DateOfBirth.ToString("MM/dd/yyyy");
            txtHometown.Text = selected_artist.Hometown.ToString();
            txtDOD.Text = selected_artist.DateOfDeath.ToString();
            txtFunFact.Text = selected_artist.FunFact.ToString();
        }

        private void DisplaySongsList(int rowIndex)
        {
            // Get the row that was clicked
            DataGridViewRow row = dgvArtists.Rows[rowIndex];
            // Get the Artist ID from that row
            int artist_id = Convert.ToInt32(row.Cells[0].Value);

            dgvSongsList.DataSource = (from artist in context.Artists
                                       join song in context.Songs
                                           on artist.ArtistId equals song.ArtistId
                                       join album in context.Albums
                                           on song.AlbumId equals album.AlbumId
                                       where artist.ArtistId == artist_id
                                       orderby song.SongName
                                       select new
                                       {
                                           artist.ArtistId,
                                           song.SongId,
                                           album.AlbumId,
                                           song.SongName
                                       }).ToList();

            // format basic grid
            BasicFormatting(dgvSongsList);

            // format the first column
            dgvSongsList.Columns[0].Visible = false;

            // format the second column
            dgvSongsList.Columns[1].Visible = false;

            // format the third column
            dgvSongsList.Columns[2].Visible = false;

            // format the forth column
            dgvSongsList.Columns[3].HeaderText = "Song Name";
            dgvSongsList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            BasicFormatting(dgvSongsList);

        }

        private void dgvSongsList__RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int artist_id = Convert.ToInt32(dgvSongsList.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            selected_artist = context.Artists.Find(artist_id);
            int song_id = Convert.ToInt32(dgvSongsList.Rows[e.RowIndex].Cells[1].Value.ToString().Trim());
            selected_song = context.Songs.Find(song_id);
            int album_id = Convert.ToInt32(dgvSongsList.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
            selected_album = context.Albums.Find(album_id);

            var individualSong = new FormSongSingle()
            {
                Song = selected_song,
                Artist = selected_artist,
                Album = selected_album
            };
            _ = individualSong.ShowDialog();
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
