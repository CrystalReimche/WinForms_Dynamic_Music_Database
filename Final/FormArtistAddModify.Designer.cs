
namespace Final
{
    partial class FormArtistAddModify
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
            this.txtDOD = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblAddModifyArtist = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.errorBirthName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBirthDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFunFact = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFunFact)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDOD
            // 
            this.txtDOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.txtDOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDOD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDOD.Location = new System.Drawing.Point(140, 254);
            this.txtDOD.Name = "txtDOD";
            this.txtDOD.Size = new System.Drawing.Size(100, 22);
            this.txtDOD.TabIndex = 33;
            this.txtDOD.Text = "mm/dd/yyyy";
            this.txtDOD.Enter += new System.EventHandler(this.txtDOD_Enter);
            this.txtDOD.Leave += new System.EventHandler(this.txtDOD_Leave);
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDOB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDOB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtDOB.Location = new System.Drawing.Point(140, 168);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(100, 22);
            this.txtDOB.TabIndex = 32;
            this.txtDOB.Text = "mm/dd/yyyy";
            this.txtDOB.Enter += new System.EventHandler(this.txtDOB_Enter);
            this.txtDOB.Leave += new System.EventHandler(this.txtDOB_Leave);
            // 
            // lblAddModifyArtist
            // 
            this.lblAddModifyArtist.AutoSize = true;
            this.lblAddModifyArtist.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddModifyArtist.Location = new System.Drawing.Point(72, 26);
            this.lblAddModifyArtist.Name = "lblAddModifyArtist";
            this.lblAddModifyArtist.Size = new System.Drawing.Size(206, 28);
            this.lblAddModifyArtist.TabIndex = 31;
            this.lblAddModifyArtist.Text = "Add New Artist";
            this.lblAddModifyArtist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Silver;
            this.btnCancel.Location = new System.Drawing.Point(210, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 30;
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
            this.btnSave.Location = new System.Drawing.Point(30, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 31);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFunFact
            // 
            this.lblFunFact.AutoSize = true;
            this.lblFunFact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFunFact.Location = new System.Drawing.Point(31, 297);
            this.lblFunFact.Name = "lblFunFact";
            this.lblFunFact.Size = new System.Drawing.Size(68, 14);
            this.lblFunFact.TabIndex = 28;
            this.lblFunFact.Text = "Fun Fact:";
            // 
            // lblDOD
            // 
            this.lblDOD.AutoSize = true;
            this.lblDOD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOD.Location = new System.Drawing.Point(31, 254);
            this.lblDOD.Name = "lblDOD";
            this.lblDOD.Size = new System.Drawing.Size(103, 14);
            this.lblDOD.TabIndex = 27;
            this.lblDOD.Text = "Date of Death:";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHometown.Location = new System.Drawing.Point(31, 211);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(78, 14);
            this.lblHometown.TabIndex = 26;
            this.lblHometown.Text = "Hometown";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.Location = new System.Drawing.Point(31, 168);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(96, 14);
            this.lblDOB.TabIndex = 25;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtFunFact
            // 
            this.txtFunFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.txtFunFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFunFact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFunFact.Location = new System.Drawing.Point(140, 297);
            this.txtFunFact.Name = "txtFunFact";
            this.txtFunFact.Size = new System.Drawing.Size(177, 22);
            this.txtFunFact.TabIndex = 24;
            // 
            // txtHometown
            // 
            this.txtHometown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.txtHometown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHometown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHometown.Location = new System.Drawing.Point(140, 211);
            this.txtHometown.Name = "txtHometown";
            this.txtHometown.Size = new System.Drawing.Size(177, 22);
            this.txtHometown.TabIndex = 23;
            // 
            // txtBirthName
            // 
            this.txtBirthName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.txtBirthName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthName.Location = new System.Drawing.Point(140, 125);
            this.txtBirthName.Name = "txtBirthName";
            this.txtBirthName.Size = new System.Drawing.Size(177, 22);
            this.txtBirthName.TabIndex = 22;
            // 
            // txtStageName
            // 
            this.txtStageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(164)))), ((int)(((byte)(151)))));
            this.txtStageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStageName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStageName.Location = new System.Drawing.Point(140, 82);
            this.txtStageName.Name = "txtStageName";
            this.txtStageName.Size = new System.Drawing.Size(177, 22);
            this.txtStageName.TabIndex = 21;
            // 
            // lblBirthName
            // 
            this.lblBirthName.AutoSize = true;
            this.lblBirthName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirthName.Location = new System.Drawing.Point(30, 125);
            this.lblBirthName.Name = "lblBirthName";
            this.lblBirthName.Size = new System.Drawing.Size(86, 14);
            this.lblBirthName.TabIndex = 20;
            this.lblBirthName.Text = "Birth Name:";
            // 
            // lblStageName
            // 
            this.lblStageName.AutoSize = true;
            this.lblStageName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStageName.Location = new System.Drawing.Point(31, 82);
            this.lblStageName.Name = "lblStageName";
            this.lblStageName.Size = new System.Drawing.Size(92, 14);
            this.lblStageName.TabIndex = 19;
            this.lblStageName.Text = "Stage Name:";
            // 
            // errorBirthName
            // 
            this.errorBirthName.ContainerControl = this;
            // 
            // errorBirthDate
            // 
            this.errorBirthDate.ContainerControl = this;
            // 
            // errorFunFact
            // 
            this.errorFunFact.ContainerControl = this;
            // 
            // FormArtistAddModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(344, 387);
            this.Controls.Add(this.txtDOD);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblAddModifyArtist);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArtistAddModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArtistAddModify";
            this.Load += new System.EventHandler(this.FormArtistAddModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFunFact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDOD;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblAddModifyArtist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
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
        private System.Windows.Forms.ErrorProvider errorBirthName;
        private System.Windows.Forms.ErrorProvider errorBirthDate;
        private System.Windows.Forms.ErrorProvider errorFunFact;
    }
}