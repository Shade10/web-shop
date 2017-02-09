using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_shop.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwe kursu")]
        [StringLength(100)]
        public string TitleCourse { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwe autora")]
        [StringLength(50)]
        public string AuthorCourse { get; set; }
        public DateTime DateAdded { get; set; }
        [StringLength(100)]
        public string NameFileImage { get; set; }
        public string DescriptionCourse { get; set; }
        public decimal CoursePrice  { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }
        public string shortDescription { get; set; }

        public virtual Category Category { get; set; }

    }
}