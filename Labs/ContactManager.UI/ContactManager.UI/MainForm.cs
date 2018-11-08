/* Marissa Greise
 * ITSE 1430
 * 11/01/2018
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
            _listBoxSentMessages.DisplayMember = "Name";

            RefreshContacts();
            RefreshMessages();
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
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new ContactForm();
            form.Text = "Edit Contact";
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Contact);
            RefreshContacts();
        }

        private Contact GetSelectedContact()
        {
            return _listBoxContacts.SelectedItem as Contact;
        }

        private Message GetSelectedMessge()
        {
            return _listBoxSentMessages.SelectedItem as Message;
        }

        private void OnContactDoubleClick( object sender, EventArgs e )
        {
            EditContact();
        }

        private IMessageServices _sentMessages = new MemoryMessageDatabase();
        private IContactDatabase _database = new MemoryContactDatabase();

        private void OnContactDelete( object sender, EventArgs e )
        {
            DeleteContact();
        }

        private void DeleteContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete " + item.Name + " ?",
                     "Delete Contact", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            
            _database.Remove(item.Name);
            RefreshContacts();
        }

        private void OnListKeyUp( object sender, KeyEventArgs e )
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteContact();
            };
        }

        private void OnMessageSend( object sender, EventArgs e )
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new MessageForm();
            form.Contact = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _sentMessages.Send(form.Message);
            RefreshMessages();
        }

        private void RefreshMessages()
        {
            var messages = from m in _sentMessages.GetAll()
                           select m;

            _listBoxSentMessages.Items.Clear();
            _listBoxSentMessages.Items.AddRange(messages.ToArray());
        }
    }
}
