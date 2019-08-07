using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConceptualMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name="Name")]
        public string StudentName { get; set; }

        [Range(5,30)]
        public int Age { get; set; }
    }
}