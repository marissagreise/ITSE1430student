﻿namespace Itse1430.MovieLib.UI
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._chkOwned = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(100, 28);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(156, 20);
            this._txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(100, 63);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(156, 44);
            this._txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release Year";
            // 
            // _txtReleaseYear
            // 
            this._txtReleaseYear.Location = new System.Drawing.Point(100, 131);
            this._txtReleaseYear.Name = "_txtReleaseYear";
            this._txtReleaseYear.Size = new System.Drawing.Size(52, 20);
            this._txtReleaseYear.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Run Length";
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(100, 179);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(52, 20);
            this._txtRunLength.TabIndex = 7;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(111, 307);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 8;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(203, 307);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 9;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _chkOwned
            // 
            this._chkOwned.AutoSize = true;
            this._chkOwned.Location = new System.Drawing.Point(106, 230);
            this._chkOwned.Name = "_chkOwned";
            this._chkOwned.Size = new System.Drawing.Size(66, 17);
            this._chkOwned.TabIndex = 10;
            this._chkOwned.Text = "Owned?";
            this._chkOwned.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 351);
            this.ControlBox = false;
            this.Controls.Add(this._chkOwned);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._txtReleaseYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.ShowInTaskbar = false;
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtReleaseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.CheckBox _chkOwned;
    }
}