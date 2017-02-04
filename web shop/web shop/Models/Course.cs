using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace web_shop.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int CategoryID { get; set; }
        public string TitleCourse { get; set; }
        public string AuthorCourse { get; set; }
        public DateTime DateAdded { get; set; }
        public string NameFileImage { get; set; }
        public string DescriptionCourse { get; set; }
        public decimal CoursePrice  { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public virtual Category Category { get; set; }

    }
}