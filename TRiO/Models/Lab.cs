﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TRiO.Models
{
    public class Lab
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the lab."), MaxLength(100), Display(Name = "Lab Name")]
        public string Name { get; set; }

        [MaxLength(10), Display(Name = "Room Number")]
        public string Room { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}