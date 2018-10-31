using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public  abstract class MovieDatabase : IMovieDatabase
    { 
        public void Add (Movie movie)
        {
            if (movie == null)
                throw new ArgumentNullException("movie");
            ObjectValidator.Validate(movie);
            
            //todo: validate

            AddCore(movie);
        }

        protected abstract void AddCore ( Movie movie );

        public IEnumerable<Movie> GetAll()
        {
            return GetAllCore();
        }

        protected abstract IEnumerable<Movie> GetAllCore();

        public void Edit (string name, Movie movie)
        {
            // Validate
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            else if (name == "")
                throw new ArgumentException("Name cannot be empty.", nameof(name));  
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));
            ObjectValidator.Validate(movie);

            // Find movie by name
            var existing = FindByName(name);
            if (existing == null)
                throw new Exception("Movie not found.");

            EditCore(existing, movie);
        }

        protected abstract Movie FindByName( string name );
        protected abstract void EditCore( Movie oldMovie, Movie newMovie );

        public void Remove (string name)
        {
            //todo :validate
            if (String.IsNullOrEmpty(name))
                return;

            RemoveCore(name);
        }

        protected abstract void RemoveCore( string name );
        
    }
}
