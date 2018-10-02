﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Movie Movie;

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave( object sender, EventArgs e )
        {
            var movie = new Movie();
            //var movie2 = new Movie();
            //var name = movie2.GetName();

            //Name is required
            movie.Name = _txtName.Text; // writing to it
            //movie.SetName(_txtName.Text);
            if (String.IsNullOrEmpty(movie.Name)) //reading to it
                return;

            //movie.SetDescription (_txtDescription.Text);
            movie.Description = _txtDescription.Text;

            // Release year is numeric, if set
            movie.ReleaseYear = GetInt32(_txtReleaseYear);
            //movie.SetReleaseYear(GetInt32(_txtReleaseYear));
            if (movie.ReleaseYear < 0)
                return;

            //Run length, if set
            movie.RunLength = GetInt32(_txtRunLength);
            //movie.SetRunLength(GetInt32(_txtRunLength));
            if (movie.RunLength < 0)
                return;

            Movie = movie;

            DialogResult = DialogResult.OK; 
            Close();
        }

        private int GetInt32(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return 0;

            if (Int32.TryParse(textBox.Text, out var value))
                return value;

            return -1;
        }
    }
}
