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

        public Character Character { get; set; }

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

            character.Strength = GetInt32(_txtStrength);
            if (character.Strength < 0 && character.Strength > 100)
                return;

            character.Intelligence = GetInt32(_txtIntelligence);
            if (character.Intelligence  < 0 && character.Intelligence > 100)
                return;

            character.Agility = GetInt32(_txtAgility);
            if (character.Agility < 0 && character.Agility > 100)
                return;

            character.Constitution = GetInt32(_txtConstitution);
            if (character.Constitution < 0 && character.Constitution > 100)
                return;

            character.Charisma = GetInt32(_txtCharisma);
            if (character.Charisma < 0 && character.Charisma > 100)
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

        private void CharacterForm_Load( object sender, EventArgs e )
        {
            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _comboProfession.Text = Character.Profession;
                _comboRace.Text = Character.Race;
                _txtStrength.Text = Character.Strength.ToString();
                _txtIntelligence.Text = Character.Intelligence.ToString();
                _txtAgility.Text = Character.Agility.ToString();
                _txtConstitution.Text = Character.Constitution.ToString();
                _txtCharisma.Text = Character.Charisma.ToString();
                _txtDescription.Text = Character.Description;
            };
        }
    }
}
