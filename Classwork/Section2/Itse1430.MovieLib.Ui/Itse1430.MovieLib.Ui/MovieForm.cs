﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLib.UI
{
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
        }
        public Movie Movie { get; set; }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            //var movie = new Movie();

            //movie.Name = _txtName.Text; // writing to it
            //movie.Description = _txtDescription.Text;
            //movie.ReleaseYear = GetInt32(_txtReleaseYear);
            //movie.RunLength = GetInt32(_txtRunLength);
            //movie.IsOwed = _chkOwned.Checked; // if checked it is true

            // Initializer syntax
            var movie = new Movie() { 
                Name = _txtName.Text, // writing to it
                Description = _txtDescription.Text,
                ReleaseYear = GetInt32(_txtReleaseYear),
                RunLength = GetInt32(_txtRunLength),
                IsOwned = _chkOwned.Checked, // if checked it is true
            };

            var results = ObjectValidator.Validate(movie);
            foreach (var result in results)
            {
                MessageBox.Show(this, result.ErrorMessage, "Validation Failed",
                               MessageBoxButtons.OK);
                return;
            }
            
            Movie = movie;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32( TextBox textBox )
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }

        private void MovieForm_Load( object sender, EventArgs e )
        {
            if (Movie != null)
            {
                _txtName.Text = Movie.Name;
                _txtDescription.Text = Movie.Description;
                _txtReleaseYear.Text = Movie.ReleaseYear.ToString();
                _txtRunLength.Text = Movie.RunLength.ToString();
                _chkOwned.Checked = Movie.IsOwned;
            }

            ValidateChildren();
        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, "Name is Required");
                e.Cancel = true;
            } else
                errorProvider1.SetError(control, "");
        }

        private void OnValidatingReleaseYear( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 1900)
            {
                errorProvider1.SetError(control, "Must be > 1900");
                e.Cancel = true;
            } else
                errorProvider1.SetError(control, "");
        }

        private void OnValidatingRunLength( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 0)
            {
                errorProvider1.SetError(control, "Must be > 0");
                e.Cancel = true;
            } else
                errorProvider1.SetError(control, "");
        }
    }
}
