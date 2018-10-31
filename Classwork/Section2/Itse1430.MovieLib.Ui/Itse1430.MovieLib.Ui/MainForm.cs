using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Itse1430.MovieLib.Memory;

namespace Itse1430.MovieLib.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // this method can be overriden in a derived type
        //protected virtual void SomeFunction()
        //{

        //}

        //This method MUST BE defined in a derived type
        //protected abstract void SomeAbstractFunction();
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _database.Add(new Movie());
            //Seed database
            _database.Seed();

            _listMovies.DisplayMember = "Name";
            RefreshMovies();
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
            //aboutToolStripMenuItem.
            MessageBox.Show(this, "Sorry", "Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        }

        private void OnMovieAdd( object sender, EventArgs e )
        {
            var form = new MovieForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            //MessageBox.Show("Adding movie");
            _database.Add(form.Movie);                  // this is how to get data from different member
            //Movie.Name = " ";
            RefreshMovies();
        }


        private void RefreshMovies()
        {
            //Orderby
            //var movies = _database.GetAll();
            var movies = from m in _database.GetAll()
                         orderby m.Name
                         select m;

            _listMovies.Items.Clear();

            //TODO: Hard way
            //foreach (var movie in movies)
            //    _listMovies.Items.Add(movie);
            _listMovies.Items.AddRange(movies.ToArray());
        }

        private void EditMovie()
        {
            var item = GetSelectedMovie();
            if (item == null)
                return;

            var form = new MovieForm();
            form.Movie = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            // add to database and refresh
            _database.Edit(item.Name, form.Movie);                  // this is how to get data from different member
            RefreshMovies();
        }

        private void OnMovieDelete( object sender, EventArgs e )
        {
            DeleteMovie();
        }

        private void OnMovieEdit( object sender, EventArgs e )
        {
            EditMovie();
        }

        private void OnMovieDoubleClick( object sender, EventArgs e )
        {
            EditMovie();
        }

        private void OnListKeyUp( object sender, KeyEventArgs e )
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteMovie();
            }
        }

        private void DeleteMovie()
        {
            var item = GetSelectedMovie();
            if (item == null)
                return;

            _database.Remove(item.Name);
            RefreshMovies();
        }
        private Movie GetSelectedMovie()
        {
            return _listMovies.SelectedItem as Movie;       // using the as operator
        }
        private IMovieDatabase _database = new MemoryMovieDatabase();

    }
}
