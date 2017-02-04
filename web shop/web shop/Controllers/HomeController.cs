using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_shop.DAL;
using web_shop.Models;

namespace web_shop.Controllers
{
    public class HomeController : Controller
    {
        private CoursesContext db = new CoursesContext();


        // GET: Home
        public ActionResult Index()
        {
            Category category = new Category {CategoryName = "asp.net mvc", NameFileIcon = "aspNetMvc.png", DescriptionCategory = "opis"};
            db.Categories.Add(category);
            db.SaveChanges();


            return View();
        }
    }
}