
namespace Final
{
    partial class FormDeleteShowSongs
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvDeletedSongs = new System.Windows.Forms.DataGridView();
            this.lblSongList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(173, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.Silver;
            this.btnOk.Location = new System.Drawing.Point(40, 240);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 31);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvDeletedSongs
            // 
            this.dgvDeletedSongs.AllowUserToAddRows = false;
            this.dgvDeletedSongs.AllowUserToDeleteRows = false;
            this.dgvDeletedSongs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.dgvDeletedSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeletedSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedSongs.Location = new System.Drawing.Point(40, 84);
            this.dgvDeletedSongs.Name = "dgvDeletedSongs";
            this.dgvDeletedSongs.ReadOnly = true;
            this.dgvDeletedSongs.RowTemplate.Height = 25;
            this.dgvDeletedSongs.Size = new System.Drawing.Size(240, 150);
            this.dgvDeletedSongs.TabIndex = 5;
            // 
            // lblSongList
            // 
            this.lblSongList.AutoSize = true;
            this.lblSongList.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongList.Location = new System.Drawing.Point(46, 13);
            this.lblSongList.MaximumSize = new System.Drawing.Size(240, 0);
            this.lblSongList.Name = "lblSongList";
            this.lblSongList.Size = new System.Drawing.Size(224, 36);
            this.lblSongList.TabIndex = 4;
            this.lblSongList.Text = "The following songs will be deleted:";
            this.lblSongList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeleteShowSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(320, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvDeletedSongs);
            this.Controls.Add(this.lblSongList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeleteShowSongs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeleteShowSongs";
            this.Load += new System.EventHandler(this.FormDeleteShowSongs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvDeletedSongs;
        private System.Windows.Forms.Label lblSongList;
    }
}