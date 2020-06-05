using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;
using Microsoft.EntityFrameworkCore;

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

        public Project FindCreatorbyProject(int projectid)
        {
            return db.Projects.Include(proj => proj.ProjectCreator)
                .Where(proj => proj.Id == projectid).FirstOrDefault();
        }

        public Project Update(ProjectOption projOption, int projectId)
        {

            Project project = db.Projects.Find(projectId);

            if (projOption.Category != null)
                project.Category = projOption.Category;
            if (projOption.Title != null)
                project.Title = projOption.Title;
            if (projOption.Description != null)
                project.Description = projOption.Description;
            if (projOption.StatusUpdate != null)
                project.StatusUpdate = projOption.StatusUpdate;
            if (projOption.Goal != null)
                project.Goal = projOption.Goal ?? 0;
            

            db.SaveChanges();
            return project;
        }

        public List<FundingPackage> ShowFundingPackages(int projectId)  //ok
        {
            //xreiazetai na psaxnoyme sti vasi i na epistrefoyme ti lista toy modeloy project?
            return db.FundingPackages.Where(fundingPackage => fundingPackage.Project.Id == projectId).ToList();
        }

        public Project FindProjectById(int projectId)
        {
            return db.Projects.Find(projectId);
        }
    }
}
