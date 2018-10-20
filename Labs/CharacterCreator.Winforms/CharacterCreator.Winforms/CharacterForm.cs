/* Marissa Greise
 * ITSE 1430
 * 10/20/2018
 */

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
            if (!ValidateChildren())
                return;

            var character = new Character();
           
            character.Name = _txtName.Text;
            character.Profession = _comboProfession.Text;
            character.Race = _comboRace.Text;
            character.Strength = GetInt32(_txtStrength);
            character.Intelligence = GetInt32(_txtIntelligence);
            character.Agility = GetInt32(_txtAgility);
            character.Constitution = GetInt32(_txtConstitution);
            character.Charisma = GetInt32(_txtCharisma);
            character.Description =_txtDescription.Text;

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32 (TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;
            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

        private void CharacterForm_Load( object sender, EventArgs e )
        {
            _comboProfession.SelectedIndex = 0;
            _comboRace.SelectedIndex = 0;

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

            ValidateChildren();
        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _error.SetError(control, "Name is resquired");
                e.Cancel = true;
            } else
                _error.SetError(control, "");

        }

        private void OnValidatingStrength( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _error.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }

        private void OnValidatingIntelligence( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _error.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            } else
                _error.SetError(control, "");

        }

        private void OnValidatingAgility( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _error.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }

        private void OnValidatingConstitution( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _error.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }

        private void OnValidatingCharisma( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                _error.SetError(control, "Must be between 1-100");
                e.Cancel = true;
            } else
                _error.SetError(control, "");
        }
    }
}
