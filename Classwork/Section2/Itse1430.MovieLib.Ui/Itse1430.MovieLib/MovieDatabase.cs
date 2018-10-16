using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public class MovieDatabase
    {
        public MovieDatabase() : this(true)
        {
        }

        public MovieDatabase(bool seed) :  this (GetSeedMovies(seed))
        {

        }

        private static Movie[] GetSeedMovies( bool seed )
        {
            if (!seed)
                return new Movie[0];

            return new [] {
                new Movie() {
                    Name = "Jaws",
                    RunLength = 120,
                    ReleaseYear = 1997,
                },
                new Movie()
                {
                    Name = "What about Bob",
                    RunLength = 96,
                    ReleaseYear = 2004,
                },
        };

        }
        public MovieDatabase(Movie[ ] movies )
        {
            _items.AddRange(movies);

        }
        public void Add (Movie movie)
        {
            _items.Add(movie);
        }

        //private int FindNextFreeIndex ()
        //{
        //    for (var index =0; index < _movies.Length; ++index)
        //    {
        //        if (_movies[index] == null)
        //            return index;
        //    };

        //    return -1;
        //}
    

        public Movie[] GetAll()
        {
            // how many movies do we have
            var count = _items.Count;

            var temp = new Movie[count];
            var index = 0;
            foreach (var movie in _items)
            {
                temp[index++] = movie;
            }
            return temp;
        }

        public void Edit (string name, Movie movie)
        {
            // Find movie by name
            Remove(name);
            // Replace it
            Add(movie);
        }
        public void Remove (string name)
        {
            var movie = FindMovie(name);
            if (movie != null)
                _items.Remove(movie);
        }
        private Movie FindMovie (string name)
        {
            foreach (var movie in _items)
            {
                if (String.Compare(name, movie.Name, true) == 0)
                    return movie;
            };

            return null;
        }

       // private Movie[] _movies = new Movie[100];
        private List<Movie> _items = new List<Movie>();
    }
}
