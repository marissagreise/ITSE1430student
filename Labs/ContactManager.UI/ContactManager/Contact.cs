﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Contact : IValidatableObject
    {
        public string Name
        {
            get => _name ?? "";
            set => _name = value;
        }
        private string _name = "";

        public string EmailAddress
        {
            get => _emailAddress ?? "";
            set => _emailAddress = value;
        }
        private string _emailAddress = "";

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {

            if (String.IsNullOrEmpty(Name))
                yield return new ValidationResult("Name is required.",
                                new[] { nameof(Name) });

            if (String.IsNullOrEmpty(EmailAddress))
                yield return new ValidationResult("Name is required.",
                                new[] { nameof(EmailAddress) });

        }
    }
}
