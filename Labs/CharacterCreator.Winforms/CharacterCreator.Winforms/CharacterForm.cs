using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        public Character Character;

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            var character = new Character();
           
            character.Name = _txtName.Text;
            if (String.IsNullOrEmpty(character.Name))
                return;

            character.Profession = _comboProfession.Text;

            character.Race = _comboRace.Text;

            character.SetAttributes (GetInt32(_txtAttributes));
            if (character.GetAttributes() < 0)
                return;

            character.Description =_txtDescription.Text;

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32 (TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;
            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

    }
}
