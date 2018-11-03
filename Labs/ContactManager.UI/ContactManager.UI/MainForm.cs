using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
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
            MessageBox.Show(this, "Marissa Greise\nITSE 1430\nContact Manager",
               "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void OnContactAdd( object sender, EventArgs e )
        {
            var form = new ContactForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Contact);
            RefreshContacts();
        }

        private void RefreshContacts()
        {
            var movies = from m in _database.GetAll()
                         orderby m.Name
                         select m;

            _listMovies.Items.Clear();
            
            _listMovies.Items.AddRange(movies.ToArray());
        }
        //private IMovieDatabase _database = new MemoryMovieDatabase();
    }
}
