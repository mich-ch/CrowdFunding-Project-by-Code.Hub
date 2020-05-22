using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class ProjectManagment : IProjectManager
    {
        private CrmDbContext db;

        public ProjectManagment(CrmDbContext _db)
        {
            db = _db;


        }

        public Project CreateProject(ProjectOption projectOption)
        {
            Project project = new Project
            {
                ProjectCreatorId = projectOption.ProjectCreatorId,
                Title = projectOption.Title,
                Description = projectOption.Description,
                StatusUpdate = projectOption.StatusUpdate,
                TotalFundings = projectOption.TotalFundings,
                Goal = projectOption.Goal,
                Category = projectOption.Category,
                Active = true
            };
            db.Projects.Add(project);
            db.SaveChanges();
            return project;
        }
        public List<FundingPackage> ShowFundingPackages()
        {
            return db.FundingPackages.ToList();
        }



    }
}
