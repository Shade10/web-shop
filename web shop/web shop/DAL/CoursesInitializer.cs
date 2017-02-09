using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using web_shop.Models;

namespace web_shop.DAL
{
    public class CoursesInitializer : DropCreateDatabaseAlways<CoursesContext>
    {
        protected override void Seed(CoursesContext context)
        {
            SeedCoursesDate(context);
            base.Seed(context);
        }

        private void SeedCoursesDate(CoursesContext context)
        {
            var category = new List<Category>
            {
                new Category() { CategoryID=1, CategoryName = "asp", NameFileIcon="asp.png", DescriptionCategory="Opis asp net mvc" },
                new Category() { CategoryID=2, CategoryName = "java", NameFileIcon="java.png", DescriptionCategory="Opis java" },
                new Category() { CategoryID=3, CategoryName = "php", NameFileIcon="php.png", DescriptionCategory="Opis php" },
                new Category() { CategoryID=4, CategoryName = "html", NameFileIcon="html.png", DescriptionCategory="Opis html" },
                new Category() { CategoryID=5, CategoryName = "css", NameFileIcon="css.png", DescriptionCategory="Opis css" },
                new Category() { CategoryID=6, CategoryName = "xml", NameFileIcon="xml.png", DescriptionCategory="Opis xml" },
                new Category() { CategoryID=7, CategoryName = "C#", NameFileIcon="C#.png", DescriptionCategory="Opis C#" }
            };
            category.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course() { AuthorCourse="Tomek", TitleCourse="asp.net mvc", CategoryID=1, CoursePrice=99, Bestseller=true, NameFileImage="obrazekaspnet.png",
                               DateAdded=DateTime.Now, DescriptionCourse="opis kursu"},
                new Course() { AuthorCourse="Jomek", TitleCourse="asp.net mvc", CategoryID=1, CoursePrice=49, Bestseller=true, NameFileImage="obrazekaspnet.png",
                               DateAdded=DateTime.Now, DescriptionCourse="opis kursu2"},
                new Course() { AuthorCourse="Janek", TitleCourse="asp.net mvc", CategoryID=1, CoursePrice=345, Bestseller=true, NameFileImage="obrazekaspnet.png",
                               DateAdded=DateTime.Now, DescriptionCourse="opis kursu3"},
                new Course() { AuthorCourse="Franek", TitleCourse="asp.net mvc", CategoryID=1, CoursePrice=199, Bestseller=true, NameFileImage="obrazekaspnet.png",
                               DateAdded=DateTime.Now, DescriptionCourse="opis kursu4"},
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

        }
    }
}