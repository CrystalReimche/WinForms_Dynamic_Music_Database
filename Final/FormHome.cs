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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        MusicContext context = new MusicContext();

        FormArtists formArtists = new FormArtists();
        FormAlbums formAlbums = new FormAlbums();
        FormSongs formSongs = new FormSongs();

        Artists selected_artist = null;
        Albums selected_album = null;
        Songs selected_song = null;

        FormArtistAddModify addArtistForm = new FormArtistAddModify();
        FormAlbumAddModify addAlbumForm = new FormAlbumAddModify();
        FormSongAddModify addSongForm = new FormSongAddModify();


        private void btnHome_Click(object sender, EventArgs e)
        {
            HideForms();
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            HideForms();

            formArtists.Show();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            HideForms();

            formAlbums.Show();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            HideForms();

            formSongs.Show();
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            HideForms();

            addArtistForm = new FormArtistAddModify()
            {
                AddArtist = true,

            };
            DialogResult result = addArtistForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selected_artist = addArtistForm.Artist;
                context.Artists.Add(selected_artist);
                context.SaveChanges();
                MessageBox.Show($"{selected_artist.StageName} has been added!");
                formArtists.Show();
            }
            else
            {
                addArtistForm.Close();
            }
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            HideForms();

            addAlbumForm = new FormAlbumAddModify()
            {
                AddAlbum = true,
                Artists = context.Artists.OrderBy(a => a.StageName).ToList()
            };


            DialogResult result = addAlbumForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                selected_album = addAlbumForm.Album;
                context.Albums.Add(selected_album);
                context.SaveChanges();
                MessageBox.Show($"{selected_album.AlbumName} has been added!");
                formAlbums.Show();
            }
            else
            {
                addAlbumForm.Close();
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            HideForms();

            addSongForm = new FormSongAddModify()
            {
                AddSong = true,
                Artists = context.Artists.OrderBy(a => a.StageName).ToList(),
                Albums = context.Albums.OrderBy(a => a.AlbumName).ToList()
            };

            DialogResult result = addSongForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                selected_song = addSongForm.Song;
                context.Songs.Add(selected_song);
                context.SaveChanges();
                MessageBox.Show($"{selected_song.SongName} has been added!");
                formSongs.Show();
            }
            else
            {
                addSongForm.Close();
            }


        }





        private void HideForms()
        {
            formAlbums.Hide();
            formSongs.Hide();
            formArtists.Hide();
            addArtistForm.Hide();
            addAlbumForm.Hide();
            addSongForm.Hide();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
