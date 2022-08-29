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
    public partial class FormAlbumAddModify : Form
    {
        public FormAlbumAddModify()
        {
            InitializeComponent();
        }

        public Albums Album { get; set; }
        public List<Artists> Artists { get; set; }
        public bool AddAlbum { get; set; }

        private void FormAlbumAddModify_Load(object sender, EventArgs e)
        {
            
            LoadComboBox();

            if (AddAlbum)
            {
                lblAddEditAlbum.Text = "Add New Album";
                Album = new Albums();
            }
            else
            {
                lblAddEditAlbum.Text = "Modify Album";
                DisplayAlbum();
            }
        }

        private void LoadComboBox()
        {

            cboArtists.DataSource = Artists;
            cboArtists.ValueMember = "ArtistId";
            cboArtists.DisplayMember = "StageName";
        }

        private void DisplayAlbum()
        {
            txtAlbum.Text = Album.AlbumName;
            cboArtists.SelectedValue = Album.ArtistId;
            txtGenre.Text = Album.Genre;
            txtRecordLabel.Text = Album.RecordLabel;
            txtReleaseDate.Text = Album.ReleaseDate.ToString("MM/dd/yyyy");
            txtNotablefact.Text = Album.NotableFact;
        }

        private void LoadData()
        {
            Album.AlbumName = txtAlbum.Text;
            Album.ArtistId = Convert.ToInt32(cboArtists.SelectedValue);
            Album.Genre = txtGenre.Text;
            Album.RecordLabel = txtRecordLabel.Text;
            Album.ReleaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            Album.NotableFact = txtNotablefact.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAlbum.Text.Trim()))
            {
                errorAlbum.SetError(txtAlbum, "required");
            }
            else if (string.IsNullOrEmpty(txtGenre.Text.Trim()))
            {
                ClearErrors();
                errorGenre.SetError(txtGenre, "required");
            }
            else if (string.IsNullOrEmpty(txtRecordLabel.Text.Trim()))
            {
                ClearErrors();
                errorRecord.SetError(txtRecordLabel, "required");
            }
            else if (string.IsNullOrEmpty(txtReleaseDate.Text.Trim()) || txtReleaseDate.Text == "mm/dd/yyyy")
            {
                ClearErrors();
                errorRelease.SetError(txtReleaseDate, "required");
            }
            else if (txtReleaseDate.Text.Length < 6 || txtReleaseDate.Text.Length > 10)
            {
                ClearErrors();
                errorRelease.SetError(txtReleaseDate, "invalid format (mm/dd/yyyy)");
            }
            else
            {
                LoadData();
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearErrors()
        {
            errorAlbum.Clear();
            errorGenre.Clear();
            errorRecord.Clear();
            errorRelease.Clear();
        }

        /********************************************* 
                         PLACE HOLDERS
         *********************************************/
        #region PLACE HOLDERS
        private void txtReleaseDate_Enter(object sender, EventArgs e)
        {
            if (txtReleaseDate.Text == "mm/dd/yyyy")
            {
                txtReleaseDate.Text = "";
                txtReleaseDate.ForeColor = Color.Black;
                txtReleaseDate.Font = new Font(txtReleaseDate.Font, FontStyle.Regular);
            }
        }

        private void txtReleaseDate_Leave(object sender, EventArgs e)
        {
            if (txtReleaseDate.Text == "")
            {
                txtReleaseDate.Text = "mm/dd/yyyy";
                txtReleaseDate.ForeColor = Color.Silver;
                txtReleaseDate.Font = new Font(txtReleaseDate.Font, FontStyle.Italic);
            }
        }

        #endregion

        
    }
}
