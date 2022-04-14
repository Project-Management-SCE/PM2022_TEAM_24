using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IdintityProject.Models
{
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Course name")]
        public string CourseName { get; set; }


        [Display(Name = "Course description")]
        public string CourseDescription { get; set; }

    }
}