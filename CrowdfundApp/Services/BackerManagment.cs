using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class BackerManagment : IBackerManager
    {
        private CrmDbContext db;

        public BackerManagment(CrmDbContext _db)
        {
            db = _db;
        }

        public Backer CreateBacker(BackerOption backerOption)   //ok
        {
            Backer backer = new Backer
            {
                FullName = backerOption.FullName,
                Address = backerOption.Address,
                Email = backerOption.Email,
                Phone = backerOption.Phone
            };
            db.Backers.Add(backer);
            db.SaveChanges();
            return backer;
        }

        public List<Project> TextProjectsSearch(string projectTitle)    //ok
        {
            return db.Projects
                     .Where(proj => proj.Title == projectTitle)
                     .ToList();
        }

        public List<Project> ShowFundingProjectsByBacker(int backerId)  //ok
        {
            Backer backer = db.Backers.Find(backerId);
            List<Project> projects = new List<Project>();

            foreach (var backerFundingPackage in backer.BackerFundingPackages)
            {
                projects.Add(backerFundingPackage.FundingPackage.Project);
            }

            return projects;
        }

        public List<Project> ShowAllProjects()  //ok
        {
            return db.Projects.ToList();
        }

        public List<Project> ShowProjectsByCategory(string category)    //ok
        {
            return db.Projects
                     .Where(Project => Project.Category == category)
                     .ToList();
        }

        public List<Project> ShowTrendsProjects()   //ok
        {
            return db.Projects.OrderByDescending(o => o.TotalFundings).Take(5).ToList();
        }

        public Backer FindBackerByEmail(BackerOption backOption)
        {
            if (backOption == null) return null;
            if (backOption.Email == null) return null;

            return db.Backers
                .Where(back => back.Email == backOption.Email)
                .FirstOrDefault();
        }
        public BackerFundingPackage Fund(int projectId, int fundingPackageId, int backerId) //ok
        {
            Project project = db.Projects.Find(projectId);
            FundingPackage fundingPackage = db.FundingPackages.Find(fundingPackageId);
            //Backer backer = db.Backers.Find(backerId);

            project.TotalFundings += fundingPackage.Price;

            BackerFundingPackage backerFundingPackage = new BackerFundingPackage
            {
                Backer = db.Backers.Find(backerId),
                FundingPackage = db.FundingPackages.Find(fundingPackageId)
            };
            db.BackerFundingPackages.Add(backerFundingPackage);
            
            db.SaveChanges();
            return backerFundingPackage;
        }
    }
}