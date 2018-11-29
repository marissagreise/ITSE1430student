using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    [Description("A Movie ")]
    public class Movie : IValidatableObject 
    {
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            //get { return _name ?? ""; } //string get()
            get => _name ?? "";

            //set { _name = value; } //void set(string value)
            set => _name = value;
            
        }
        private string _name = "";

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description;

        [Range(1900,2100, ErrorMessage = "Release year must be >= 1900.")]
        public int ReleaseYear { get; set; } = 1900; //Auto property syntax

        [Range(0, Int32.MaxValue, ErrorMessage ="Run length must be >= 0.")]
        public int RunLength { get; set; }
       
        public int Id { get;  set; }

        //Using calculated property with no setter
        public bool IsColor => ReleaseYear > 1940; // using lambda

        public bool IsOwned { get; set; }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            //var results = new List<ValidationResult>();

            //if (String.IsNullOrEmpty(Name))
            //    results.Add(new ValidationResult("Name is required.", new[] {nameof(Name)}));

            //if (ReleaseYear < 1900)
            //    yield return new ValidationResult("Release year must be >= 1900",
            //                    new[] { nameof(ReleaseYear) });

            //if (RunLength < 0)
            //    yield return new ValidationResult("Run length must be >= 0",
            //                    new[] { nameof(RunLength) });
            yield return null;  //means i have nothing to return
        }
    }
}
