﻿using CrowdfundApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Database
{
    public class CrmDbContext : DbContext
    {
        public DbSet<ProjectCreator> ProjectCreators { get; set; }
        public DbSet<Backer> Backers { get; set; }
        public DbSet<FundingPackage> FundingPackages { get; set; }
        public DbSet<BackerFundingPackage> BackerFundingPackages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Multimedia> Multimedia { get; set; }
       

        public static readonly string connectionString = /*"Server=localhost;Database=CrowdfundApp;User Id=sa;Password=admin!@#123;";*/
           "Data Source=localhost;" +
            "Initial Catalog = CrowdfundApp; " +
            "Integrated Security = True;";

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }



}
