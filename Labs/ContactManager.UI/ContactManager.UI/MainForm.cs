using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Memory;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _listBoxContacts.DisplayMember = "Name";
            RefreshContacts();
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

            _listBoxContacts.Items.Clear();
            
            _listBoxContacts.Items.AddRange(movies.ToArray());
        }

        private void OnContactEdit( object sender, EventArgs e )
        {
            EditContact();
        }

        private void EditContact()
        {
            //Get selected contact, if any
            var item = GetSelectedContact();
            if (item == null)
                return;

            //Show form with selected contact
            var form = new ContactForm();
            form.Text = "Edit Contact";
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //Update database and refresh
            _database.Edit(item.Name, form.Contact);
            RefreshContacts();
        }

        private Contact GetSelectedContact()
        {
            return _listBoxContacts.SelectedItem as Contact;
        }

        private void OnContactDoubleClick( object sender, EventArgs e )
        {
            EditContact();
        }

        private IContactDatabase _database = new MemoryContactDatabase();

    }
}
