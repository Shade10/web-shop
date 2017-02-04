using System.Collections;
using System.Collections.Generic;

namespace web_shop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string DescriptionCategory { get; set; }
        public string NameFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}