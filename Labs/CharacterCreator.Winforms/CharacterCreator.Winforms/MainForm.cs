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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            if (MessageBox.Show("Are you sure you want to exit?",
                       "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Marissa Greise\nITSE 1430\nCharacter Creator",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MainForm_Load( object sender, EventArgs e )
        {
            _listCharacters.DisplayMember = "Name";
            RefreshCharacters();

        }

        private void OnCharacterAdd( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Character);
            RefreshCharacters();
           
        }

        private void OnCharacterEdit( object sender, EventArgs e )
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            var form = new CharacterForm();
            form.Text = "Edit Character";
            form.Character = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Character);
            RefreshCharacters();

        }

        private void OnCharacterDelete( object sender, EventArgs e )
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            if (MessageBox.Show("Are you sure you want to Delete this Character?",
                      "Delete Character", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _database.Remove(item.Name);
            RefreshCharacters();
        }

        private Character GetSelectedCharacter ()
        {
            return _listCharacters.SelectedItem as Character;
        }

        private void RefreshCharacters()
        {
            var characters = _database.GetAll();

            _listCharacters.Items.Clear();
            _listCharacters.Items.AddRange(characters);
        }

        private CharacterDatabase _database = new CharacterDatabase();
    }
}
