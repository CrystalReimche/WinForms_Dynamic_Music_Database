
namespace Final
{
    partial class FormSongs
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
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.txtWriters = new System.Windows.Forms.TextBox();
            this.lblWriters = new System.Windows.Forms.Label();
            this.txtRankDate = new System.Windows.Forms.TextBox();
            this.lblRankDate = new System.Windows.Forms.Label();
            this.txtHighRank = new System.Windows.Forms.TextBox();
            this.lvlHighBillrank = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongs
            // 
            this.dgvSongs.AllowUserToAddRows = false;
            this.dgvSongs.AllowUserToDeleteRows = false;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Location = new System.Drawing.Point(12, 12);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowTemplate.Height = 25;
            this.dgvSongs.Size = new System.Drawing.Size(865, 326);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentClick);
            this.dgvSongs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSongs_RowHeaderMouseClick);
            // 
            // txtWriters
            // 
            this.txtWriters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWriters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtWriters.ForeColor = System.Drawing.Color.Silver;
            this.txtWriters.Location = new System.Drawing.Point(345, 538);
            this.txtWriters.Multiline = true;
            this.txtWriters.Name = "txtWriters";
            this.txtWriters.ReadOnly = true;
            this.txtWriters.Size = new System.Drawing.Size(238, 52);
            this.txtWriters.TabIndex = 86;
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWriters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblWriters.Location = new System.Drawing.Point(437, 511);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(76, 14);
            this.lblWriters.TabIndex = 85;
            this.lblWriters.Text = "Writer(s):";
            // 
            // txtRankDate
            // 
            this.txtRankDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRankDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRankDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRankDate.ForeColor = System.Drawing.Color.Silver;
            this.txtRankDate.Location = new System.Drawing.Point(513, 439);
            this.txtRankDate.Name = "txtRankDate";
            this.txtRankDate.ReadOnly = true;
            this.txtRankDate.Size = new System.Drawing.Size(72, 15);
            this.txtRankDate.TabIndex = 84;
            // 
            // lblRankDate
            // 
            this.lblRankDate.AutoSize = true;
            this.lblRankDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRankDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(173)))), ((int)(((byte)(246)))));
            this.lblRankDate.Location = new System.Drawing.Point(345, 442);
            this.lblRankDate.Name = "lblRankDate";
            this.lblRankDate.Size = new System.Drawing.Size(143, 14);
            this.lblRankDate.TabIndex = 83;
            this.lblRankDate.Text = "Billboard Rank Date:";
            // 
            // txtHighRank
            // 
            this.txtHighRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHighRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHighRank.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHighRank.ForeColor = System.Drawing.Color.Silver;
            this.txtHighRank.Location = new System.Drawing.Point(513, 375);
            this.txtHighRank.Name = "txtHighRank";
            this.txtHighRank.ReadOnly = true;
            this.txtHighRank.Size = new System.Drawing.Size(72, 15);
            this.txtHighRank.TabIndex = 82;
            // 
            // lvlHighBillrank
            // 
            this.lvlHighBillrank.AutoSize = true;
            this.lvlHighBillrank.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlHighBillrank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.lvlHighBillrank.Location = new System.Drawing.Point(345, 378);
            this.lvlHighBillrank.Name = "lvlHighBillrank";
            this.lvlHighBillrank.Size = new System.Drawing.Size(162, 14);
            this.lvlHighBillrank.TabIndex = 81;
            this.lvlHighBillrank.Text = "Highest Billboard Rank:";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLength.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLength.ForeColor = System.Drawing.Color.Silver;
            this.txtLength.Location = new System.Drawing.Point(122, 567);
            this.txtLength.Name = "txtLength";
            this.txtLength.ReadOnly = true;
            this.txtLength.Size = new System.Drawing.Size(171, 15);
            this.txtLength.TabIndex = 80;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(214)))), ((int)(((byte)(164)))));
            this.lblLength.Location = new System.Drawing.Point(53, 570);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(57, 14);
            this.lblLength.TabIndex = 79;
            this.lblLength.Text = "Length:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.lblArtist.Location = new System.Drawing.Point(53, 442);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(48, 14);
            this.lblArtist.TabIndex = 77;
            this.lblArtist.Text = "Artist:";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComments.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtComments.ForeColor = System.Drawing.Color.Silver;
            this.txtComments.Location = new System.Drawing.Point(677, 411);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(171, 161);
            this.txtComments.TabIndex = 75;
            // 
            // txtSong
            // 
            this.txtSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSong.ForeColor = System.Drawing.Color.Silver;
            this.txtSong.Location = new System.Drawing.Point(122, 375);
            this.txtSong.Name = "txtSong";
            this.txtSong.ReadOnly = true;
            this.txtSong.Size = new System.Drawing.Size(171, 15);
            this.txtSong.TabIndex = 74;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(128)))), ((int)(((byte)(232)))));
            this.lblComments.Location = new System.Drawing.Point(720, 378);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(81, 14);
            this.lblComments.TabIndex = 73;
            this.lblComments.Text = "Comments:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(141)))));
            this.lblAlbum.Location = new System.Drawing.Point(53, 506);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(53, 14);
            this.lblAlbum.TabIndex = 72;
            this.lblAlbum.Text = "Album:";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.lblSong.Location = new System.Drawing.Point(53, 378);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(45, 14);
            this.lblSong.TabIndex = 71;
            this.lblSong.Text = "Song:";
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtArtist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtArtist.ForeColor = System.Drawing.Color.Silver;
            this.txtArtist.Location = new System.Drawing.Point(122, 439);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.ReadOnly = true;
            this.txtArtist.Size = new System.Drawing.Size(171, 15);
            this.txtArtist.TabIndex = 87;
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAlbum.ForeColor = System.Drawing.Color.Silver;
            this.txtAlbum.Location = new System.Drawing.Point(122, 503);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.ReadOnly = true;
            this.txtAlbum.Size = new System.Drawing.Size(171, 15);
            this.txtAlbum.TabIndex = 88;
            // 
            // FormSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(889, 633);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtWriters);
            this.Controls.Add(this.lblWriters);
            this.Controls.Add(this.txtRankDate);
            this.Controls.Add(this.lblRankDate);
            this.Controls.Add(this.txtHighRank);
            this.Controls.Add(this.lvlHighBillrank);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.dgvSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSongs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSongs";
            this.Load += new System.EventHandler(this.FormSongs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.TextBox txtWriters;
        private System.Windows.Forms.Label lblWriters;
        private System.Windows.Forms.TextBox txtRankDate;
        private System.Windows.Forms.Label lblRankDate;
        private System.Windows.Forms.TextBox txtHighRank;
        private System.Windows.Forms.Label lvlHighBillrank;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
    }
}