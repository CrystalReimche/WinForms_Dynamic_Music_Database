
namespace Final
{
    partial class FormAlbumAddModify
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotablefact = new System.Windows.Forms.TextBox();
            this.lblNotableFact = new System.Windows.Forms.Label();
            this.txtReleaseDate = new System.Windows.Forms.TextBox();
            this.txtRecordLabel = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblRecordLabel = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblAddEditAlbum = new System.Windows.Forms.Label();
            this.cboArtists = new System.Windows.Forms.ComboBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.errorAlbum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorGenre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRecord = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRelease = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRelease)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(191, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 59;
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
            this.btnSave.Location = new System.Drawing.Point(37, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotablefact
            // 
            this.txtNotablefact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.txtNotablefact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotablefact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotablefact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNotablefact.Location = new System.Drawing.Point(137, 256);
            this.txtNotablefact.Name = "txtNotablefact";
            this.txtNotablefact.Size = new System.Drawing.Size(161, 22);
            this.txtNotablefact.TabIndex = 57;
            // 
            // lblNotableFact
            // 
            this.lblNotableFact.AutoSize = true;
            this.lblNotableFact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotableFact.Location = new System.Drawing.Point(36, 259);
            this.lblNotableFact.Name = "lblNotableFact";
            this.lblNotableFact.Size = new System.Drawing.Size(95, 14);
            this.lblNotableFact.TabIndex = 56;
            this.lblNotableFact.Text = "Notable Fact:";
            // 
            // txtReleaseDate
            // 
            this.txtReleaseDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.txtReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReleaseDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReleaseDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtReleaseDate.Location = new System.Drawing.Point(137, 219);
            this.txtReleaseDate.Name = "txtReleaseDate";
            this.txtReleaseDate.Size = new System.Drawing.Size(161, 22);
            this.txtReleaseDate.TabIndex = 55;
            this.txtReleaseDate.Text = "mm/dd/yyyy";
            this.txtReleaseDate.Enter += new System.EventHandler(this.txtReleaseDate_Enter);
            this.txtReleaseDate.Leave += new System.EventHandler(this.txtReleaseDate_Leave);
            // 
            // txtRecordLabel
            // 
            this.txtRecordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.txtRecordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecordLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRecordLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRecordLabel.Location = new System.Drawing.Point(137, 182);
            this.txtRecordLabel.Name = "txtRecordLabel";
            this.txtRecordLabel.Size = new System.Drawing.Size(161, 22);
            this.txtRecordLabel.TabIndex = 54;
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGenre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGenre.Location = new System.Drawing.Point(95, 145);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(203, 22);
            this.txtGenre.TabIndex = 53;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReleaseDate.Location = new System.Drawing.Point(36, 222);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(99, 14);
            this.lblReleaseDate.TabIndex = 52;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // lblRecordLabel
            // 
            this.lblRecordLabel.AutoSize = true;
            this.lblRecordLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecordLabel.Location = new System.Drawing.Point(37, 185);
            this.lblRecordLabel.Name = "lblRecordLabel";
            this.lblRecordLabel.Size = new System.Drawing.Size(98, 14);
            this.lblRecordLabel.TabIndex = 51;
            this.lblRecordLabel.Text = "Record Label:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(37, 148);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 14);
            this.lblGenre.TabIndex = 50;
            this.lblGenre.Text = "Genre:";
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlbum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlbum.Location = new System.Drawing.Point(96, 71);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(202, 22);
            this.txtAlbum.TabIndex = 49;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAlbum.Location = new System.Drawing.Point(37, 74);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(53, 14);
            this.lblAlbum.TabIndex = 48;
            this.lblAlbum.Text = "Album:";
            // 
            // lblAddEditAlbum
            // 
            this.lblAddEditAlbum.AutoSize = true;
            this.lblAddEditAlbum.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddEditAlbum.Location = new System.Drawing.Point(88, 16);
            this.lblAddEditAlbum.Name = "lblAddEditAlbum";
            this.lblAddEditAlbum.Size = new System.Drawing.Size(152, 28);
            this.lblAddEditAlbum.TabIndex = 47;
            this.lblAddEditAlbum.Text = "Add Album";
            // 
            // cboArtists
            // 
            this.cboArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(165)))), ((int)(((byte)(187)))));
            this.cboArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboArtists.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboArtists.FormattingEnabled = true;
            this.cboArtists.Location = new System.Drawing.Point(95, 108);
            this.cboArtists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboArtists.Name = "cboArtists";
            this.cboArtists.Size = new System.Drawing.Size(203, 22);
            this.cboArtists.TabIndex = 46;
            this.cboArtists.Tag = "Artist";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArtist.Location = new System.Drawing.Point(37, 111);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(48, 14);
            this.lblArtist.TabIndex = 45;
            this.lblArtist.Text = "Artist:";
            // 
            // errorAlbum
            // 
            this.errorAlbum.ContainerControl = this;
            // 
            // errorGenre
            // 
            this.errorGenre.ContainerControl = this;
            // 
            // errorRecord
            // 
            this.errorRecord.ContainerControl = this;
            // 
            // errorRelease
            // 
            this.errorRelease.ContainerControl = this;
            // 
            // FormAlbumAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(335, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotablefact);
            this.Controls.Add(this.lblNotableFact);
            this.Controls.Add(this.txtReleaseDate);
            this.Controls.Add(this.txtRecordLabel);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblRecordLabel);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.lblAddEditAlbum);
            this.Controls.Add(this.cboArtists);
            this.Controls.Add(this.lblArtist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlbumAddModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlbumAddModify";
            this.Load += new System.EventHandler(this.FormAlbumAddModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRelease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNotablefact;
        private System.Windows.Forms.Label lblNotableFact;
        private System.Windows.Forms.TextBox txtReleaseDate;
        private System.Windows.Forms.TextBox txtRecordLabel;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblReleaseDate;
        private System.Windows.Forms.Label lblRecordLabel;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblAddEditAlbum;
        private System.Windows.Forms.ComboBox cboArtists;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.ErrorProvider errorAlbum;
        private System.Windows.Forms.ErrorProvider errorGenre;
        private System.Windows.Forms.ErrorProvider errorRecord;
        private System.Windows.Forms.ErrorProvider errorRelease;
    }
}