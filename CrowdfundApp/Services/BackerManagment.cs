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

        public Backer CreateBacker(BackerOption backerOption)
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

        public List<Project> TextProjectsSearch(string projectTitle)
        {
            return db.Projects
                     .Where(proj => proj.Title == projectTitle)
                     .ToList();
        }

        public List<Project> ShowFundingProjectsByBacker(int backerId)
        {
            Backer backer = db.Backers.Find(backerId);
            List<BackerFundingPackage> backerFundingPackages = backer.BackerFundingPackages.ToList();
            List<Project> projects = new List<Project>();
            int projectId;
            foreach (var backerFundingPackage in backerFundingPackages)
            {
                projectId = backerFundingPackage.FundingPackage.ProjectId;
                projects.Add(db.Projects.Find(projectId));
            }
            return projects;
        }

        public List<Project> ShowAllProjects()
        {
            return db.Projects.ToList();
        }

        public List<Project> ShowProjectsByCategory(string category)
        {
            return db.Projects
                     .Where(Project => Project.Category == category)
                     .ToList();
        }

        public List<Project> ShowTrendsProjects()
        {
            return db.Projects.OrderByDescending(o => o.TotalFundings).Take(5).ToList();
        }

        public void Fund(int projectId, int fundingPackageId, int backerId)
        {
            Project project = db.Projects.Find(projectId);
            FundingPackage fundingPackage = db.FundingPackages.Find(fundingPackageId);
            Backer backer = db.Backers.Find(backerId);
            project.TotalFundings += fundingPackage.Price;
            BackerFundingPackage backerFundingPackage = new BackerFundingPackage
            {
                Backer = backer,
                FundingPackage = fundingPackage 
            }; 
            project.BackerFundingPackages.Add(backerFundingPackage);    //prosthiki BackerFundingPackage stin lista toy project
            db.SaveChanges();
        }
    }
}