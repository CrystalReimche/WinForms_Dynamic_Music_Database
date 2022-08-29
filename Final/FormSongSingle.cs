using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Final.Models.DataLayer;

namespace Final
{
    public partial class FormSongSingle : Form
    {
        public FormSongSingle()
        {
            InitializeComponent();
        }

        public Songs Song { get; set; }
        public Artists Artist { get; set; }
        public Albums Album { get; set; }

        private void FormSongSingle_Load(object sender, EventArgs e)
        {
            DisplayIndividualSong();
        }

        private void DisplayIndividualSong()
        {
            txtSong.Text = Song.SongName;
            txtArtist.Text = Artist.StageName;
            txtAlbum.Text = Album.AlbumName;
            txtLength.Text = Song.LengthInSeconds.ToString();
            txtRanking.Text = Song.HighestBillboardRanking.ToString();
            txtBillboardDate.Text = Song.DateOfBillboardRanking.ToString();
            txtWriters.Text = Song.WriterName;
            txtComments.Text = Song.Comments;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}