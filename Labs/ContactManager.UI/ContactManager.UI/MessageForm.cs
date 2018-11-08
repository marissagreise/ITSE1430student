using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = ContactManager.MessageSendDatabase;

namespace ContactManager.UI
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public Message Message { get; set; }
        public Contact Contact { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            Close();
        }

        private void MessageForm_Load( object sender, EventArgs e )
        {
            if (Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.EmailAddress;
            }

            if (Message != null)
            {
                _txtName.Text = Message.Name;
                _txtEmailAddress.Text = Message.EmailAddress;
            }

            ValidateChildren();
        }

        private void OnButtonSend( object sender, EventArgs e )
        {
            if(String.IsNullOrEmpty(_txtSubject.Text))
            {
                MessageBox.Show("Subject is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = new Message()
            {
                Name = _txtName.Text,
                EmailAddress = _txtEmailAddress.Text,
                Subject = _txtSubject.Text,
                ComposeMessage = _txtMessage.Text,
            };

            Message = message;
            DialogResult = DialogResult.OK;

            Close();  
        }
    }
}
