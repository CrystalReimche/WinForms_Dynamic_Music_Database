using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Final.Models.DataLayer;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Final
{
    public partial class FormAlbums : Form
    {
        public FormAlbums()
        {
            InitializeComponent();
        }

        readonly MusicContext context = new MusicContext();

        const int ModifyIndex = 7; // index for the Modify button column
        const int DeleteIndex = 8; // index for the Delete button column

        Artists selected_artist = null;
        Albums selected_album = null;
        Songs selected_song = null;

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            DisplayAlbums();
        }

        private void DisplayAlbums()
        {
            // get customers and bind grid
            dgvAlbums.Columns.Clear();

            List<AlbumList> albumLists = (from album in context.Albums
                                    join artist in context.Artists
                                        on album.ArtistId equals artist.ArtistId
                                    orderby album.AlbumName
                                    select new AlbumList
                                    {
                                        AlbumID = album.AlbumId,
                                        ArtistID = artist.ArtistId,
                                        Album_Name = album.AlbumName,
                                        Stage_Name = artist.StageName,
                                        Genre = album.Genre,
                                        Record_Label = album.RecordLabel,
                                        Release_Date = album.ReleaseDate
                                    }).ToList();

            SortableBindingList<AlbumList> sblAlbums = new SortableBindingList<AlbumList>(albumLists);
            dgvAlbums.DataSource = sblAlbums;

            BasicFormatting(dgvAlbums);

            // format the first column
            dgvAlbums.Columns[0].Visible = false;

            // format the second column
            dgvAlbums.Columns[1].Visible = false;

            // format the third column
            dgvAlbums.Columns[2].HeaderText = "Album Name";
            dgvAlbums.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // format the forth column
            dgvAlbums.Columns[3].HeaderText = "Artist";
            dgvAlbums.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // format the fifth column
            dgvAlbums.Columns[4].HeaderText = "Genre";
            dgvAlbums.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // format the sixth column
            dgvAlbums.Columns[5].HeaderText = "Record Label";
            dgvAlbums.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // format the seventh column
            dgvAlbums.Columns[6].HeaderText = "Release Date";
            dgvAlbums.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            DataGridViewButtonColumn modify_column = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Edit",
                Width = 50
            };
            dgvAlbums.Columns.Insert(ModifyIndex, modify_column);

            DataGridViewButtonColumn delete_column = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Delete",
                Width = 60
            };
            dgvAlbums.Columns.Insert(DeleteIndex, delete_column);
        }

        private void dgvAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                int album_id = Convert.ToInt32(dgvAlbums.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selected_album = context.Albums.Find(album_id);
            }
            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyAlbum();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteAlbum();
            }
        }

        private void ModifyAlbum()
        {
            var modifyAlbumsForm = new FormAlbumAddModify()
            {
                AddAlbum = false,
                Album = selected_album,
                Artists = context.Artists.OrderBy(a => a.StageName).ToList()
            };

            DialogResult result = modifyAlbumsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selected_album = modifyAlbumsForm.Album;
                context.SaveChanges();
                DisplayAlbums();
            }
            else
            {
                modifyAlbumsForm.Close();
            }
        }

        private void DeleteAlbum()
        {
            var deleteAlbumWithSongs = new FormDeleteShowSongs()
            {
                Album = selected_album
            };

            DialogResult result = deleteAlbumWithSongs.ShowDialog();

            if (result == DialogResult.OK)
            {
                context.Albums.Remove(selected_album);
                context.SaveChanges(true);
                DisplayAlbums();
            }
        }

        private void dgvAlbums_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayIndivAlbum(e.RowIndex);
            DisplaySongsList(e.RowIndex);
        }

        private void DisplayIndivAlbum(int rowIndex)
        {
            // Get the row that was clicked
            DataGridViewRow row = dgvAlbums.Rows[rowIndex];
            // Get the Artist ID from that row
            int album_id = Convert.ToInt32(row.Cells[0].Value);
            // Find the artist that has that ID
            selected_album = context.Albums.Find(album_id);
            // Get the Artist ID from that row
            int artist_id = Convert.ToInt32(row.Cells[1].Value);
            // Find the artist that has that ID
            selected_artist = context.Artists.Find(artist_id);

            // Displaying Album info 
            txtAlbum.Text = selected_album.AlbumName.ToString();
        }

        private void DisplaySongsList(int rowIndex)
        {
            dgvSongsList.Columns.Clear();

            // Get the row that was clicked
            DataGridViewRow row = dgvAlbums.Rows[rowIndex];
            // Get the Artist ID from that row
            int artist_id = Convert.ToInt32(row.Cells[0].Value);

            List<AlbumSongList> songLists = (from artist in context.Artists
                                            join song in context.Songs
                                                on artist.ArtistId equals song.ArtistId
                                            join album in context.Albums
                                                on song.AlbumId equals album.AlbumId
                                            where artist.ArtistId == artist_id
                                            orderby song.SongName
                                            select new AlbumSongList
                                            {
                                                Artist_ID = artist.ArtistId, 
                                                Album_ID = album.AlbumId,    
                                                Song_ID = song.SongId,   
                                                Song_Name = song.SongName,   
                                                Writer_Name = song.WriterName,   
                                                Highest_Billboard_Ranking = song.HighestBillboardRanking,    
                                                Length_In_Seconds = song.LengthInSeconds 
                                            }).ToList();

            SortableBindingList<AlbumSongList> sblSongs = new SortableBindingList<AlbumSongList>(songLists);
            dgvSongsList.DataSource = sblSongs;

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
            dgvSongsList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            // format the fifth column
            dgvSongsList.Columns[4].HeaderText = "Writer(s)";
            dgvSongsList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // format the sixth column
            dgvSongsList.Columns[5].HeaderText = "Billboard Ranking";
            dgvSongsList.Columns[5].Width = 80;

            // format the seventh column
            dgvSongsList.Columns[6].HeaderText = "Length";
            dgvSongsList.Columns[6].Width = 80;
        }

        private void dgvSongsList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int artist_id = Convert.ToInt32(dgvSongsList.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
            selected_artist = context.Artists.Find(artist_id);

            int album_id = Convert.ToInt32(dgvSongsList.Rows[e.RowIndex].Cells[1].Value.ToString().Trim());
            selected_album = context.Albums.Find(album_id);

            int song_id = Convert.ToInt32(dgvSongsList.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
            selected_song = context.Songs.Find(song_id);

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
    }
}
