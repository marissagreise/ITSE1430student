﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public static class MovieDatabaseExtensions
    {
        public static void Seed( this IMovieDatabase source )
        {
            var movies = new[] {
                new Movie() {
                    Name = "Jaws",
                    RunLength = 120,
                    ReleaseYear = 1977,
                },
                new Movie() {
                    Name = "What About Bob?",
                    RunLength = 96,
                    ReleaseYear = 2004,
                },
            };
            Seed(source, movies);
        }
        public static void Seed( this IMovieDatabase source, Movie[] movies )
        {
            foreach (var movie in movies)
                source.Add(movie);
        }
    }
}
