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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ContactForm_Load( object sender, EventArgs e )
        {
            if(Contact != null)
            {
                _txtName.Text = Contact.Name;
                _txtEmailAddress.Text = Contact.EmailAddress;
            };

            ValidateChildren();
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            var contact = new Contact()
            {
                Name = _txtName.Text,
                EmailAddress = _txtEmailAddress.Text,
            };

            var results = ObjectValidator.Validate(contact);
            foreach (var result in results)
            {
                MessageBox.Show(this, result.ErrorMessage, "Validation Failed",
                                 MessageBoxButtons.OK);
                return;
            };

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
