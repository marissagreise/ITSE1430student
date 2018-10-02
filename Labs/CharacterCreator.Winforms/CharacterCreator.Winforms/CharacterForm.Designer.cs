namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtAttributes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profession";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(126, 25);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(143, 20);
            this._txtName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attributes";
            // 
            // _txtAttributes
            // 
            this._txtAttributes.Location = new System.Drawing.Point(126, 179);
            this._txtAttributes.Multiline = true;
            this._txtAttributes.Name = "_txtAttributes";
            this._txtAttributes.Size = new System.Drawing.Size(143, 46);
            this._txtAttributes.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(126, 250);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(143, 96);
            this._txtDescription.TabIndex = 4;
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(126, 426);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 5;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(236, 426);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 6;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // _comboProfession
            // 
            this._comboProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboProfession.FormattingEnabled = true;
            this._comboProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._comboProfession.Location = new System.Drawing.Point(126, 74);
            this._comboProfession.Name = "_comboProfession";
            this._comboProfession.Size = new System.Drawing.Size(143, 21);
            this._comboProfession.Sorted = true;
            this._comboProfession.TabIndex = 1;
            // 
            // _comboRace
            // 
            this._comboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboRace.FormattingEnabled = true;
            this._comboRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._comboRace.Location = new System.Drawing.Point(126, 126);
            this._comboRace.Name = "_comboRace";
            this._comboRace.Size = new System.Drawing.Size(143, 21);
            this._comboRace.TabIndex = 2;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 471);
            this.ControlBox = false;
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtAttributes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(376, 510);
            this.MinimumSize = new System.Drawing.Size(376, 510);
            this.Name = "CharacterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtAttributes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
    }
}