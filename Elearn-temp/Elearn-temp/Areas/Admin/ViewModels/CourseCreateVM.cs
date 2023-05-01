﻿using System.ComponentModel.DataAnnotations;

namespace Elearn_temp.Areas.Admin.ViewModels
{
    public class CourseCreateVM
    {
        [Required(ErrorMessage = "Don't be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Don't be empty")]
        public string Price { get; set; }                // decimal yazmiriq string yazaciqki.
        [Required(ErrorMessage = "Don't be empty")]
        public int CountSale { get; set; }

        [Required(ErrorMessage = "Don't be empty")]
        public string Description { get; set; }

        public int AuthorId { get; set; }  // Author id ni verecek bize

        [Required(ErrorMessage = "Don't be empty")]
        public List<IFormFile> Photos { get; set; } 


    }
}
