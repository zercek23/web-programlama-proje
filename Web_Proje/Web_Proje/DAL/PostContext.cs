﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Web_Proje.Models;

namespace Web_Proje.DAL
{
    public class PostContext : DbContext
    {
        public PostContext() : base("aspnet-Web_Proje-20181211062336")
        {

        }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}