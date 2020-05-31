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

        public Project CreateProject(ProjectOption projectOption)   //ok
        {
            IProjectCreatorManager creatorMng = new ProjectCreatorManagment(db);    

            Project project = new Project
            {
                ProjectCreator = creatorMng.FindProjectCreator(projectOption.ProjectCreatorId),
                Title = projectOption.Title,
                Description = projectOption.Description,
                StatusUpdate = projectOption.StatusUpdate,
                TotalFundings = 0m,
                Goal = projectOption.Goal ?? 0,
                Category = projectOption.Category,
                Active = true
            };
            db.Projects.Add(project);
            db.SaveChanges();
            return project;
        }
        
        public List<FundingPackage> ShowFundingPackages(int projectId)  //ok
        {
            //xreiazetai na psaxnoyme sti vasi i na epistrefoyme ti lista toy modeloy project?
            return db.FundingPackages.Where(fundingPackage => fundingPackage.Project.Id == projectId).ToList();
        }

       
    }
}
