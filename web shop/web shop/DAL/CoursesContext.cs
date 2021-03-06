﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using web_shop.Models;

namespace web_shop.DAL
{
    public class CoursesContext : DbContext
    {
        public CoursesContext() : base("CourseContext")
        {
            
        }
        static CoursesContext()
        {
            Database.SetInitializer<CoursesContext>(new CoursesInitializer());
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrdersPositions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}