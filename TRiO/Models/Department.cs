using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TRiO.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the department"), MaxLength(100), Display(Name = "Department Name")]
        public string Name { get; set; }
    }
}