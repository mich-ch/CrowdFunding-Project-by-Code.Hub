using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class BackerManagment: IBackerManager
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

        public List<BackerProject> ShowFundingProjectsByBacker(int backerId) 
        {
            Backer backer = db.Backers.Find(backerId);
            return backer.BackerProjects.ToList();
            //return db.BackerProjects
            //         .Where(backerProject => backerProject.Backer == backer)
            //         .ToList();
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
           
            List<Project> projects = ShowAllProjects();
            List<Project> top5Projects = new List<Project>();
            int count = 0;

            List<Project> SortedList = projects.OrderBy(o => o.TotalFundings).ToList();
            foreach (var project in SortedList)
            {
                if (count >= 5) 
                {
                    break;
                }
                top5Projects.Add(project);
                count++;
            }
            return top5Projects;
        }

        public void Fund(int projectId, int fundingPackageId) 
        {
            Project project = db.Projects.Find(projectId);
            FundingPackage fundingPackage = db.FundingPackages.Find(fundingPackageId);
            project.TotalFundings += fundingPackage.Price;
        }
    }
}
