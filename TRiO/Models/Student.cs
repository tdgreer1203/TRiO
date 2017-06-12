﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace TRiO.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your first name."), MaxLength(50), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name."), MaxLength(50), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address."), MaxLength(75), EmailAddress, Display(Name = "Email Address")]
        public string Email { get; set; }

        [MaxLength(20), Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your student ID number."), MaxLength(20), Display(Name = "Student ID Number")]
        public string StudentId { get; set; }

        [MaxLength(75), Display(Name = "Card Number")]
        public string CardNumber { get; set; }
    }
}