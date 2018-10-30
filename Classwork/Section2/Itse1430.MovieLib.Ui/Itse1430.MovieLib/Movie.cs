﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public class Movie : IValidatableObject 
    {
        public string Name
        {
            //get { return _name ?? ""; } //string get()
            get => _name ?? "";

            //set { _name = value; } //void set(string value)
            set => _name = value;
            
        }
        private string _name = "";
        // public System.String Name; fully qualified namespace

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description;

        public int ReleaseYear { get; set; } = 1900; //Auto property syntax

        public int RunLength { get; set; }
       
        public int Id { get; private set; }

        //Using calculated property with no setter
        public bool IsColor => ReleaseYear > 1940; // using lambda

        public bool IsOwned { get; set; }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var results = new List<ValidationResult>();

            if (String.IsNullOrEmpty(Name))
                results.Add(new ValidationResult("Name is required.", new[] {nameof(Name)}));

            if (ReleaseYear < 1900)
                results.Add(new ValidationResult("Release year must be >= 1900", new[] { nameof(ReleaseYear) }));

            if (RunLength < 0)
                results.Add(new ValidationResult("Run Length must be >= 0", new[] { nameof(RunLength) }));

            return results;
        }
    }
}
