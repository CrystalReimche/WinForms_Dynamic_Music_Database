using Final.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final
{
    public partial class FormArtistAddModify : Form
    {
        public FormArtistAddModify()
        {
            InitializeComponent();
        }

        public Artists Artist { get; set; }
        public bool AddArtist { get; set; }

        private void FormArtistAddModify_Load(object sender, EventArgs e)
        {
            if (AddArtist)
            {
                lblAddModifyArtist.Text = "Add New Artist";
                Artist = new Artists();
            }
            else
            {
                lblAddModifyArtist.Text = "Modify Artist";
                DisplayArtist();
            }

        }

        private void DisplayArtist()
        {
            txtStageName.Text = Artist.StageName.ToString();
            txtBirthName.Text = Artist.BirthName.ToString();
            txtDOB.Text = Artist.DateOfBirth.ToString("MM/dd/yyyy");
            txtHometown.Text = Artist.Hometown.ToString();
            txtDOD.Text = Artist.DateOfDeath.ToString();
            txtFunFact.Text = Artist.FunFact.ToString();
        }

        private void LoadData()
        {
            DateTime dt;

            Artist.StageName = txtStageName.Text;
            Artist.BirthName = txtBirthName.Text;
            if (DateTime.TryParse(txtDOB.Text, out dt))
            {
                Artist.DateOfBirth = dt;
            }
            else
            {
                Close();
            }
            Artist.Hometown = txtHometown.Text;
            if (DateTime.TryParse(txtDOD.Text, out dt))
            {
                Artist.DateOfDeath = dt;
            }
            else
            {
                Artist.DateOfDeath = null;
            }
            Artist.FunFact = txtFunFact.Text;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBirthName.Text.Trim()))
            {
                errorBirthName.SetError(txtBirthName, "required");
            }
            else if (string.IsNullOrEmpty(txtDOB.Text.Trim()) || txtDOB.Text == "mm/dd/yyyy")
            {
                ClearErrors();
                errorBirthDate.SetError(txtDOB, "required");
            }
            else if (txtDOB.Text.Length < 6 || txtDOB.Text.Length > 10)
            {
                ClearErrors();
                errorBirthDate.SetError(txtDOB, "invalid format (mm/dd/yyyy)");
            }
            else if (string.IsNullOrEmpty(txtFunFact.Text.Trim()))
            {
                ClearErrors();
                errorFunFact.SetError(txtFunFact, "required");
            }
            else
            {
                LoadData();
                DialogResult = DialogResult.OK;
            }
        }

        private void ClearErrors()
        {
            errorBirthName.Clear();
            errorBirthDate.Clear();
            errorFunFact.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /********************************************* 
                        PLACE HOLDERS
        *********************************************/
        #region PLACE HOLDERS
        private void txtDOB_Enter(object sender, EventArgs e)
        {
            if (txtDOB.Text == "mm/dd/yyyy")
            {
                txtDOB.Text = "";
                txtDOB.ForeColor = Color.Black;
                txtDOB.Font = new Font(txtDOB.Font, FontStyle.Regular);
            }
        }

        private void txtDOB_Leave(object sender, EventArgs e)
        {
            if (txtDOB.Text == "")
            {
                txtDOB.Text = "mm/dd/yyyy";
                txtDOB.ForeColor = Color.Silver;
                txtDOB.Font = new Font(txtDOD.Font, FontStyle.Italic);
            }
        }
        private void txtDOD_Enter(object sender, EventArgs e)
        {
            if (txtDOD.Text == "mm/dd/yyyy")
            {
                txtDOD.Text = "";
                txtDOD.ForeColor = Color.Black;
                txtDOD.Font = new Font(txtDOD.Font, FontStyle.Regular);
            }
        }

        private void txtDOD_Leave(object sender, EventArgs e)
        {
            if (txtDOD.Text == "")
            {
                txtDOD.Text = "mm/dd/yyyy";
                txtDOD.ForeColor = Color.Silver;
                txtDOD.Font = new Font(txtDOD.Font, FontStyle.Italic);
            }
        }
        #endregion

    }
}
