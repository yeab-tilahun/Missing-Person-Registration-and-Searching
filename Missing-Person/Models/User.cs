﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Missing_Person.Models
{
    public class User: IdentityUser
    {
        [Required(ErrorMessage ="Please enter your first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        [NotMapped]
        public IFormFileCollection? ProfileImagePath { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="Password and confirmation passworddo not match")]
        public string? ConfirmPassword { get; set; }
        public List<MissingPerson>? MissingPersons { get; set; }
        
    }
}
