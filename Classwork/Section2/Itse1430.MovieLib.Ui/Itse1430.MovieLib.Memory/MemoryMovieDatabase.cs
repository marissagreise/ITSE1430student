using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib.Memory
{
    public class MemoryMovieDatabase : MovieDatabase
    {
        protected override void AddCore( Movie movie )
        {
           // throw new Exception("Failed");
                  _items.Add(movie);
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            return from item in _items
                   select new Movie() { 
                    Name = item.Name,
                    Description = item.Description,
                    ReleaseYear = item.ReleaseYear,
                    RunLength = item.RunLength,
                    IsOwned = item.IsOwned
             };
            //return _items.Select(item => new Movie()
            //{

            //    Name = item.Name,
            //    Description = item.Description,
            //    ReleaseYear = item.ReleaseYear,
            //    RunLength = item.RunLength,
            //    IsOwned = item.IsOwned
            //});
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
            //return _items.FirstOrDefault(m => String.Compare(name, m.Name, true) == 0);
            return (from m in _items
                   where String.Compare(name, m.Name, true) == 0
                   select m).FirstOrDefault();
        }

        private List<Movie> _items = new List<Movie>();
    }
}
