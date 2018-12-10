/*
 * Marissa Greise
 * ITSE 1430 
 * 12/5/2018
 */
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

        public EventModel( ScheduledEvent item )
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                Description = item.Description;
                StartDate = item.StartDate;
                EndDate = item.EndDate;
                IsPublic = item.IsPublic;

            };
        }

        public ScheduledEvent ToDomain()
        {
            return new ScheduledEvent()
            {
                Id = Id,
                Name = Name,
                Description = Description,
                StartDate = StartDate,
                EndDate = EndDate,
                IsPublic = IsPublic
            };
        }

        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DateGreaterThan("StartDate")]
        public DateTime EndDate { get; set; }
        public bool IsPublic { get; set; }

    }
        [AttributeUsage(AttributeTargets.Property)]
        public class DateGreaterThanAttribute : ValidationAttribute
        {
            public DateGreaterThanAttribute(string dateToCompare)
            {
                DateToCompare = dateToCompare;
            }
            private string DateToCompare { get; set; }

            protected override ValidationResult IsValid( object value, ValidationContext validationContext )
            {
                DateTime endDate = (DateTime)value;

                DateTime startDate = (DateTime)validationContext.ObjectType.
                GetProperty(DateToCompare).GetValue(validationContext.ObjectInstance, null);
                var model = validationContext.ObjectInstance as EventModel;

                if (endDate > startDate)
                {
                    return ValidationResult.Success;
                } else
                {
                    return new ValidationResult("Date is not later than start date");
                }              
            }
        }
    
 }