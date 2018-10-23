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
            return _items;
           
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
            foreach (var movie in _items)
            {
                if (String.Compare(name, movie.Name, true) == 0)
                    return movie;
            };

            return null;
        }
        
        private List<Movie> _items = new List<Movie>();
    }
}
