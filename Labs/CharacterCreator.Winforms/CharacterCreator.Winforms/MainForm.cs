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

        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
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

        private void OnCharacterAdd( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Character);
            RefreshCharacters();
           
        }

        private Character Character;

        private void MainForm_Load( object sender, EventArgs e )
        {
            _listCharacters.DisplayMember = "Name";

        }

        private void RefreshCharacters ()
        {
            var characters = _database.GetAll();

            _listCharacters.Items.Clear();
            _listCharacters.Items.AddRange(characters);
        }

        private CharacterDatabase _database = new CharacterDatabase();
    }
}
