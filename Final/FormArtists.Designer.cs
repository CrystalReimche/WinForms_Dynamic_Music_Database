
namespace Final
{
    partial class FormArtists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArtists = new System.Windows.Forms.DataGridView();
            this.txtDOD = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblFunFact = new System.Windows.Forms.Label();
            this.lblDOD = new System.Windows.Forms.Label();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtFunFact = new System.Windows.Forms.TextBox();
            this.txtHometown = new System.Windows.Forms.TextBox();
            this.txtBirthName = new System.Windows.Forms.TextBox();
            this.txtStageName = new System.Windows.Forms.TextBox();
            this.lblBirthName = new System.Windows.Forms.Label();
            this.lblStageName = new System.Windows.Forms.Label();
            this.dgvSongsList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtists
            // 
            this.dgvArtists.AllowUserToAddRows = false;
            this.dgvArtists.AllowUserToDeleteRows = false;
            this.dgvArtists.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvArtists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtists.Location = new System.Drawing.Point(12, 12);
            this.dgvArtists.Name = "dgvArtists";
            this.dgvArtists.ReadOnly = true;
            this.dgvArtists.RowTemplate.Height = 25;
            this.dgvArtists.Size = new System.Drawing.Size(865, 326);
            this.dgvArtists.TabIndex = 0;
            this.dgvArtists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtists_CellContentClick);
            this.dgvArtists.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArtists_RowHeaderMouseClick);
            // 
            // txtDOD
            // 
            this.txtDOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDOD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDOD.ForeColor = System.Drawing.Color.Silver;
            this.txtDOD.Location = new System.Drawing.Point(135, 582);
            this.txtDOD.Name = "txtDOD";
            this.txtDOD.ReadOnly = true;
            this.txtDOD.Size = new System.Drawing.Size(153, 15);
            this.txtDOD.TabIndex = 45;
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDOB.ForeColor = System.Drawing.Color.Silver;
            this.txtDOB.Location = new System.Drawing.Point(135, 528);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(153, 15);
            this.txtDOB.TabIndex = 44;
            // 
            // lblFunFact
            // 
            this.lblFunFact.AutoSize = true;
            this.lblFunFact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFunFact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblFunFact.Location = new System.Drawing.Point(365, 366);
            this.lblFunFact.Name = "lblFunFact";
            this.lblFunFact.Size = new System.Drawing.Size(68, 14);
            this.lblFunFact.TabIndex = 43;
            this.lblFunFact.Text = "Fun Fact:";
            // 
            // lblDOD
            // 
            this.lblDOD.AutoSize = true;
            this.lblDOD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.lblDOD.Location = new System.Drawing.Point(26, 585);
            this.lblDOD.Name = "lblDOD";
            this.lblDOD.Size = new System.Drawing.Size(103, 14);
            this.lblDOD.TabIndex = 42;
            this.lblDOD.Text = "Date of Death:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHometown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(141)))));
            this.lblHometown.Location = new System.Drawing.Point(26, 477);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(83, 14);
            this.lblHometown.TabIndex = 41;
            this.lblHometown.Text = "Hometown:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(214)))), ((int)(((byte)(164)))));
            this.lblDOB.Location = new System.Drawing.Point(26, 531);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 14);
            this.lblDOB.TabIndex = 40;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtFunFact
            // 
            this.txtFunFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFunFact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFunFact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFunFact.ForeColor = System.Drawing.Color.Silver;
            this.txtFunFact.Location = new System.Drawing.Point(311, 398);
            this.txtFunFact.Multiline = true;
            this.txtFunFact.Name = "txtFunFact";
            this.txtFunFact.ReadOnly = true;
            this.txtFunFact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFunFact.Size = new System.Drawing.Size(171, 202);
            this.txtFunFact.TabIndex = 39;
            // 
            // txtHometown
            // 
            this.txtHometown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHometown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHometown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHometown.ForeColor = System.Drawing.Color.Silver;
            this.txtHometown.Location = new System.Drawing.Point(124, 474);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.ReadOnly = true;
            this.txtHometown.Size = new System.Drawing.Size(164, 15);
            this.txtHometown.TabIndex = 38;
            // 
            // txtBirthName
            // 
            this.txtBirthName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBirthName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirthName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBirthName.ForeColor = System.Drawing.Color.Silver;
            this.txtBirthName.Location = new System.Drawing.Point(124, 420);
            this.txtBirthName.Name = "txtBirthName";
            this.txtBirthName.ReadOnly = true;
            this.txtBirthName.Size = new System.Drawing.Size(164, 15);
            this.txtBirthName.TabIndex = 37;
            // 
            // txtStageName
            // 
            this.txtStageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStageName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStageName.ForeColor = System.Drawing.Color.Silver;
            this.txtStageName.Location = new System.Drawing.Point(124, 366);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.ReadOnly = true;
            this.txtStageName.Size = new System.Drawing.Size(164, 15);
            this.txtStageName.TabIndex = 36;
            // 
            // lblBirthName
            // 
            this.lblBirthName.AutoSize = true;
            this.lblBirthName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.lblBirthName.Location = new System.Drawing.Point(26, 423);
            this.lblBirthName.Name = "lblBirthName";
            this.lblBirthName.Size = new System.Drawing.Size(86, 14);
            this.lblBirthName.TabIndex = 35;
            this.lblBirthName.Text = "Birth Name:";
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.lblStageName.Location = new System.Drawing.Point(26, 369);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(92, 14);
            this.lblStageName.TabIndex = 34;
            this.lblStageName.Text = "Stage Name:";
            // 
            // dgvSongsList
            // 
            this.dgvSongsList.AllowUserToAddRows = false;
            this.dgvSongsList.AllowUserToDeleteRows = false;
            this.dgvSongsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSongsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSongsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongsList.Location = new System.Drawing.Point(488, 366);
            this.dgvSongsList.Name = "dgvSongsList";
            this.dgvSongsList.ReadOnly = true;
            this.dgvSongsList.RowTemplate.Height = 25;
            this.dgvSongsList.Size = new System.Drawing.Size(389, 252);
            this.dgvSongsList.TabIndex = 46;
            this.dgvSongsList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongsList__RowHeaderMouseClick);
            // 
            // FormArtists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(889, 633);
            this.Controls.Add(this.dgvSongsList);
            this.Controls.Add(this.txtDOD);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblFunFact);
            this.Controls.Add(this.lblDOD);
            this.Controls.Add(this.lblHometown);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtFunFact);
            this.Controls.Add(this.txtHometown);
            this.Controls.Add(this.txtBirthName);
            this.Controls.Add(this.txtStageName);
            this.Controls.Add(this.lblBirthName);
            this.Controls.Add(this.lblStageName);
            this.Controls.Add(this.dgvArtists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArtists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArtists";
            this.Load += new System.EventHandler(this.FormArtists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtists;
        private System.Windows.Forms.TextBox txtDOD;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblFunFact;
        private System.Windows.Forms.Label lblDOD;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtFunFact;
        private System.Windows.Forms.TextBox txtHometown;
        private System.Windows.Forms.TextBox txtBirthName;
        private System.Windows.Forms.TextBox txtStageName;
        private System.Windows.Forms.Label lblBirthName;
        private System.Windows.Forms.Label lblStageName;
        private System.Windows.Forms.DataGridView dgvSongsList;
    }
}