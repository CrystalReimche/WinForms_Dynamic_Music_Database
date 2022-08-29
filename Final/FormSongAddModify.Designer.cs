
namespace Final
{
    partial class FormSongAddModify
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
            this.components = new System.ComponentModel.Container();
            this.txtWriters = new System.Windows.Forms.TextBox();
            this.lblWriters = new System.Windows.Forms.Label();
            this.txtRankDate = new System.Windows.Forms.TextBox();
            this.lblRankDate = new System.Windows.Forms.Label();
            this.txtHighRank = new System.Windows.Forms.TextBox();
            this.lvlHighBillrank = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.cboArtists = new System.Windows.Forms.ComboBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboAlbums = new System.Windows.Forms.ComboBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.lblAddEditSong = new System.Windows.Forms.Label();
            this.errorLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSong = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWriters = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWriters)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWriters
            // 
            this.txtWriters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.txtWriters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWriters.Location = new System.Drawing.Point(105, 314);
            this.txtWriters.Name = "txtWriters";
            this.txtWriters.Size = new System.Drawing.Size(158, 22);
            this.txtWriters.TabIndex = 70;
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWriters.Location = new System.Drawing.Point(23, 317);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(76, 14);
            this.lblWriters.TabIndex = 69;
            this.lblWriters.Text = "Writer(s):";
            // 
            // txtRankDate
            // 
            this.txtRankDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.txtRankDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRankDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRankDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRankDate.Location = new System.Drawing.Point(170, 273);
            this.txtRankDate.Name = "txtRankDate";
            this.txtRankDate.Size = new System.Drawing.Size(91, 22);
            this.txtRankDate.TabIndex = 68;
            this.txtRankDate.Text = "YYYY";
            this.txtRankDate.Enter += new System.EventHandler(this.txtRankDate_Enter);
            this.txtRankDate.Leave += new System.EventHandler(this.txtRankDate_Leave);
            // 
            // lblRankDate
            // 
            this.lblRankDate.AutoSize = true;
            this.lblRankDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRankDate.Location = new System.Drawing.Point(21, 276);
            this.lblRankDate.Name = "lblRankDate";
            this.lblRankDate.Size = new System.Drawing.Size(143, 14);
            this.lblRankDate.TabIndex = 67;
            this.lblRankDate.Text = "Billboard Rank Date:";
            // 
            // txtHighRank
            // 
            this.txtHighRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.txtHighRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHighRank.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHighRank.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtHighRank.Location = new System.Drawing.Point(191, 232);
            this.txtHighRank.Name = "txtHighRank";
            this.txtHighRank.Size = new System.Drawing.Size(72, 22);
            this.txtHighRank.TabIndex = 66;
            this.txtHighRank.Text = "E.g. 1, 7, 9";
            this.txtHighRank.Enter += new System.EventHandler(this.txtHighRank_Enter);
            this.txtHighRank.Leave += new System.EventHandler(this.txtHighRank_Leave);
            // 
            // lvlHighBillrank
            // 
            this.lvlHighBillrank.AutoSize = true;
            this.lvlHighBillrank.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlHighBillrank.Location = new System.Drawing.Point(23, 235);
            this.lvlHighBillrank.Name = "lvlHighBillrank";
            this.lvlHighBillrank.Size = new System.Drawing.Size(162, 14);
            this.lvlHighBillrank.TabIndex = 65;
            this.lvlHighBillrank.Text = "Highest Billboard Rank:";
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLength.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLength.Location = new System.Drawing.Point(90, 191);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(171, 22);
            this.txtLength.TabIndex = 64;
            this.txtLength.Text = "Length in seconds";
            this.txtLength.Enter += new System.EventHandler(this.txtLength_Enter);
            this.txtLength.Leave += new System.EventHandler(this.txtLength_Leave);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLength.Location = new System.Drawing.Point(21, 194);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(57, 14);
            this.lblLength.TabIndex = 63;
            this.lblLength.Text = "Length:";
            // 
            // cboArtists
            // 
            this.cboArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.cboArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboArtists.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboArtists.FormattingEnabled = true;
            this.cboArtists.Location = new System.Drawing.Point(90, 109);
            this.cboArtists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboArtists.Name = "cboArtists";
            this.cboArtists.Size = new System.Drawing.Size(171, 22);
            this.cboArtists.TabIndex = 62;
            this.cboArtists.Tag = "Album";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.Location = new System.Drawing.Point(21, 112);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(48, 14);
            this.lblArtist.TabIndex = 61;
            this.lblArtist.Text = "Artist:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(156, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Silver;
            this.btnSave.Location = new System.Drawing.Point(23, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboAlbums
            // 
            this.cboAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.cboAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAlbums.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAlbums.FormattingEnabled = true;
            this.cboAlbums.Location = new System.Drawing.Point(90, 150);
            this.cboAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAlbums.Name = "cboAlbums";
            this.cboAlbums.Size = new System.Drawing.Size(171, 22);
            this.cboAlbums.TabIndex = 58;
            this.cboAlbums.Tag = "Album";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComments.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComments.Location = new System.Drawing.Point(105, 355);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(158, 22);
            this.txtComments.TabIndex = 57;
            // 
            // txtSong
            // 
            this.txtSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(146)))), ((int)(((byte)(142)))));
            this.txtSong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSong.Location = new System.Drawing.Point(90, 68);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(171, 22);
            this.txtSong.TabIndex = 56;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComments.Location = new System.Drawing.Point(23, 358);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(81, 14);
            this.lblComments.TabIndex = 55;
            this.lblComments.Text = "Comments:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.Location = new System.Drawing.Point(21, 153);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(53, 14);
            this.lblAlbum.TabIndex = 54;
            this.lblAlbum.Text = "Album:";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSong.Location = new System.Drawing.Point(21, 71);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(45, 14);
            this.lblSong.TabIndex = 53;
            this.lblSong.Text = "Song:";
            // 
            // lblAddEditSong
            // 
            this.lblAddEditSong.AutoSize = true;
            this.lblAddEditSong.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddEditSong.Location = new System.Drawing.Point(80, 18);
            this.lblAddEditSong.Name = "lblAddEditSong";
            this.lblAddEditSong.Size = new System.Drawing.Size(134, 28);
            this.lblAddEditSong.TabIndex = 52;
            this.lblAddEditSong.Text = "Add Song";
            // 
            // errorLength
            // 
            this.errorLength.ContainerControl = this;
            // 
            // errorSong
            // 
            this.errorSong.ContainerControl = this;
            // 
            // errorWriters
            // 
            this.errorWriters.ContainerControl = this;
            // 
            // FormSongAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.txtWriters);
            this.Controls.Add(this.lblWriters);
            this.Controls.Add(this.txtRankDate);
            this.Controls.Add(this.lblRankDate);
            this.Controls.Add(this.txtHighRank);
            this.Controls.Add(this.lvlHighBillrank);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.cboArtists);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboAlbums);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.lblAddEditSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSongAddModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSongAddModify";
            this.Load += new System.EventHandler(this.FormSongAddModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWriters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWriters;
        private System.Windows.Forms.Label lblWriters;
        private System.Windows.Forms.TextBox txtRankDate;
        private System.Windows.Forms.Label lblRankDate;
        private System.Windows.Forms.TextBox txtHighRank;
        private System.Windows.Forms.Label lvlHighBillrank;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ComboBox cboArtists;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboAlbums;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label lblAddEditSong;
        private System.Windows.Forms.ErrorProvider errorLength;
        private System.Windows.Forms.ErrorProvider errorSong;
        private System.Windows.Forms.ErrorProvider errorWriters;
    }
}