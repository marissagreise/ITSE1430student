using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPlanner.Mvc.Models
{
    public class EventModel
    {
            public EventModel()
            {
            }

            //Using simple mapping layer using a constructor
            public EventModel( EventPlanner.ScheduledEvent item )
            {
                if (item != null)
                {
                    Id = item.Id;
                    Name = item.Name;
                    Description = item.Description;
                    StartDate = item.StartDate;
                    EndDate = item.EndDate;
                  
                };
            }

            ////Using a simple mapping layer using a method
            //public Itse1430.MovieLib.Movie ToDomain()
            //{
            //    return new Itse1430.MovieLib.Movie()
            //    {
            //        Name = Name,
            //        Description = Description,
            //        ReleaseYear = ReleaseYear,
            //        RunLength = RunLength,
            //        IsOwned = IsOwned,
            //    };
            //}
            

            [Required(AllowEmptyStrings = false)]
            public string Name { get; set; }

            public string Description { get; set; }

            [Display(Name = "Start Date")]
            public DateTime StartDate { get; set; };

            [Display(Name = "End Date")]
            [DateCorrectRange(ValidateEndDate = true, ErrorMessage = "End Date must be >= Start Date.")]
            public DateTime EndDate { get; set; }

            public int Id { get; set; }

        }
        [AttributeUsage(AttributeTargets.Property)]
        public class DateCorrectRangeAttribute : ValidationAttribute
        {
            public bool ValidateStartDate { get; set; }
            public bool ValidateEndDate { get; set; }

            protected override ValidationResult IsValid( object value, ValidationContext validationContext )
            {
                var model = validationContext.ObjectInstance as EventModel;

                if (model != null)
                {
                    if (model.StartDate > model.EndDate && ValidateEndDate
                        || (model.StartDate > DateTime.Now.Date && ValidateStartDate))
                    {
                        return new ValidationResult(string.Empty);
                    }
                }

                return ValidationResult.Success;
            }
        }
    }