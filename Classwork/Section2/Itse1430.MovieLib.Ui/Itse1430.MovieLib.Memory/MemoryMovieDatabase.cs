using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        protected override void AddCore (Movie movie)
        {
            _items.Add(movie);
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            return _items.Select(Clone);            
        }

        protected override void EditCore ( Movie oldMovie, Movie newMovie )
        {
            // Find movie by name
            _items.Remove(oldMovie);
            // Replace it
            _items.Add(newMovie);
        }
        protected override void RemoveCore (string name)
        {
            var movie = FindByName(name);
            if (movie != null)
                _items.Remove(movie);
        }
        protected override Movie FindByName (string name)
        {
            return _items.FirstOrDefault(IsName);
        }

        private Movie Clone( Movie item )
        {
            return new Movie()
            {
                Name = item.Name,
                Description = item.Description,
                ReleaseYear = item.ReleaseYear,
                RunLength = item.RunLength,
                IsOwned = item.IsOwned
            };
        }

        private bool IsName (Movie movie)
        {
            if (String.Compare(name, movie.Name, true) == 0)
                return true;

            return false;
        }

        private List<Movie> _items = new List<Movie>();
    }
}
