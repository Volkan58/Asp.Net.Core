﻿using Core_Proje_Api.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.Dal.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A532VLH\\SQLEXPRESS;database=CoreProjeDb2;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
