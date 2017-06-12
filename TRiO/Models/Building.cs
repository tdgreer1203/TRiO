using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TRiO.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the building."), MaxLength(75), Display(Name = "Building Name")]
        public string Name { get; set; }
    }
}