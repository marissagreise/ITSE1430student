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
            this._txtStrength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtDescription = new System.Windows.Forms.TextBox();
            this._buttonSave = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._comboProfession = new System.Windows.Forms.ComboBox();
            this._comboRace = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
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
            this.label4.Location = new System.Drawing.Point(28, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attributes (1-100)";
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(129, 199);
            this._txtStrength.Multiline = true;
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(41, 20);
            this._txtStrength.TabIndex = 3;
            this._txtStrength.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // _txtDescription
            // 
            this._txtDescription.Location = new System.Drawing.Point(126, 309);
            this._txtDescription.Multiline = true;
            this._txtDescription.Name = "_txtDescription";
            this._txtDescription.Size = new System.Drawing.Size(195, 75);
            this._txtDescription.TabIndex = 8;
            // 
            // _buttonSave
            // 
            this._buttonSave.Location = new System.Drawing.Point(126, 426);
            this._buttonSave.Name = "_buttonSave";
            this._buttonSave.Size = new System.Drawing.Size(75, 23);
            this._buttonSave.TabIndex = 9;
            this._buttonSave.Text = "Save";
            this._buttonSave.UseVisualStyleBackColor = true;
            this._buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(236, 426);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Strength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Intelligence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Agility";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Constitution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Charisma";
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(201, 199);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(41, 20);
            this._txtIntelligence.TabIndex = 4;
            this._txtIntelligence.Text = "50";
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(280, 199);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(41, 20);
            this._txtAgility.TabIndex = 5;
            this._txtAgility.Text = "50";
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(126, 255);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(41, 20);
            this._txtConstitution.TabIndex = 6;
            this._txtConstitution.Text = "50";
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(201, 255);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(41, 20);
            this._txtCharisma.TabIndex = 7;
            this._txtCharisma.Text = "50";
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 471);
            this.ControlBox = false;
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._comboRace);
            this.Controls.Add(this._comboProfession);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonSave);
            this.Controls.Add(this._txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtStrength);
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
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtStrength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtDescription;
        private System.Windows.Forms.Button _buttonSave;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.ComboBox _comboProfession;
        private System.Windows.Forms.ComboBox _comboRace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtIntelligence;
        private System.Windows.Forms.TextBox _txtAgility;
        private System.Windows.Forms.TextBox _txtConstitution;
        private System.Windows.Forms.TextBox _txtCharisma;
    }
}