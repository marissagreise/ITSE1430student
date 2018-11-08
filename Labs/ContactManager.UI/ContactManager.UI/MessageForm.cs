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

        public Message message { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            Close();
        }

        private void MessageForm_Load( object sender, EventArgs e )
        {
            if (message != null)
            {
                _txtName.Text = message.Name;
                _txtEmailAddress.Text = message.EmailAddress;
            }
        }
    }
}
