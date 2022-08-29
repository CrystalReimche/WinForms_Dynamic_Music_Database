using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Final.Models.DataLayer;

namespace Final
{
    public partial class FormSongAddModify : Form
    {
        public FormSongAddModify()
        {
            InitializeComponent();
        }

        public Songs Song { get; set; }
        public List<Artists> Artists { get; set; }
        public List<Albums> Albums { get; set; }
        public bool AddSong { get; set; }

        private void FormSongAddModify_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            if (AddSong)
            {
                lblAddEditSong.Text = "Add New Song";
                Song = new Songs();
            }
            else
            {
                lblAddEditSong.Text = "Modify Song";
                DisplaySong();
            }
        }

        private void LoadComboBox()
        {
            cboArtists.DataSource = Artists;
            cboArtists.ValueMember = "ArtistId";
            cboArtists.DisplayMember = "StageName";

            cboAlbums.DataSource = Albums;
            cboAlbums.ValueMember = "AlbumId";
            cboAlbums.DisplayMember = "AlbumName";
        }

        private void DisplaySong()
        {
            txtSong.Text = Song.SongName;
            cboArtists.SelectedValue = Song.ArtistId;
            cboAlbums.SelectedValue = Song.AlbumId;
            txtLength.Text = Song.LengthInSeconds.ToString();
            txtHighRank.Text = Song.HighestBillboardRanking.ToString();
            txtRankDate.Text = Song.DateOfBillboardRanking.ToString();
            txtWriters.Text = Song.WriterName;
            txtComments.Text = Song.Comments;
        }

        private void LoadData()
        {
            Song.SongName = txtSong.Text;
            Song.ArtistId = Convert.ToInt32(cboArtists.SelectedValue);
            Song.AlbumId = Convert.ToInt32(cboAlbums.SelectedValue);
            Song.LengthInSeconds = Convert.ToInt32(txtLength.Text);

            if (txtHighRank.Text == "" || txtHighRank.Text == "E.g. 1, 7, 13")
            {
                Song.HighestBillboardRanking = null;
            }
            else
            {
                Song.HighestBillboardRanking = Convert.ToInt32(txtHighRank.Text);
            }
            if (txtRankDate.Text == "" || txtRankDate.Text == "YYYY")
            {
                Song.DateOfBillboardRanking = null;
            }
            else
            {
                Song.DateOfBillboardRanking = Convert.ToInt32(txtRankDate.Text);
            }

            Song.WriterName = txtWriters.Text;
            Song.Comments = txtComments.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSong.Text.Trim()))
            {
                errorSong.SetError(txtSong, "required");
            }
            else if (Regex.IsMatch(txtLength.Text, "[^0-9]"))
            {
                ClearErrors();
                errorLength.SetError(txtLength, "Length must be integers only");
                return;
            }
            else if (string.IsNullOrEmpty(txtWriters.Text.Trim()))
            {
                ClearErrors();
                errorWriters.SetError(txtWriters, "required");
            }
            else
            {
                LoadData();
                DialogResult = DialogResult.OK;
            }
        }

        private void ClearErrors()
        {
            errorSong.Clear();
            errorWriters.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /********************************************* 
                         PLACE HOLDERS
         *********************************************/
        #region PLACE HOLDERS
        private void txtLength_Enter(object sender, EventArgs e)
        {
            if (txtLength.Text == "Length in seconds")
            {
                txtLength.Text = "";
                txtLength.ForeColor = Color.Black;
                txtLength.Font = new Font(txtLength.Font, FontStyle.Regular);
            }
        }

        private void txtLength_Leave(object sender, EventArgs e)
        {
            if (txtLength.Text == "")
            {
                txtLength.Text = "Length in seconds";
                txtLength.ForeColor = Color.Silver;
                txtLength.Font = new Font(txtLength.Font, FontStyle.Italic);
            }
        }

        private void txtRankDate_Enter(object sender, EventArgs e)
        {
            if (txtRankDate.Text == "YYYY")
            {
                txtRankDate.Text = "";
                txtRankDate.ForeColor = Color.Black;
                txtRankDate.Font = new Font(txtRankDate.Font, FontStyle.Regular);
            }
        }

        private void txtRankDate_Leave(object sender, EventArgs e)
        {
            if (txtRankDate.Text == "")
            {
                txtRankDate.Text = "YYYY";
                txtRankDate.ForeColor = Color.Silver;
                txtRankDate.Font = new Font(txtRankDate.Font, FontStyle.Italic);
            }
        }

        private void txtHighRank_Enter(object sender, EventArgs e)
        {
            if (txtHighRank.Text == "E.g. 1, 7, 13")
            {
                txtHighRank.Text = "";
                txtHighRank.ForeColor = Color.Black;
                txtHighRank.Font = new Font(txtHighRank.Font, FontStyle.Regular);
            }
        }

        private void txtHighRank_Leave(object sender, EventArgs e)
        {
            if (txtHighRank.Text == "")
            {
                txtHighRank.Text = "E.g. 1, 7, 13";
                txtHighRank.ForeColor = Color.Silver;
                txtHighRank.Font = new Font(txtHighRank.Font, FontStyle.Italic);
            }
        }
        #endregion

    }
}
