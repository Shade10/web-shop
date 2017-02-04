using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web_shop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwe kategorii")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        public string DescriptionCategory { get; set; }
        public string NameFileIcon { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}