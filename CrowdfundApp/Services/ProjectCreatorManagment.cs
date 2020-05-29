using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class ProjectCreatorManagment: IProjectCreatorManager
    {
        private CrmDbContext db;

        public ProjectCreatorManagment(CrmDbContext _db)
        {
            db = _db;
        }

        public ProjectCreator FindProjectCreatorByEmail(ProjectCreatorOption projCreatorOption)
        {
            if (projCreatorOption == null) return null;
            if (projCreatorOption.Email == null) return null;

            return db.ProjectCreators
                .Where(projCreator => projCreator.Email == projCreatorOption.Email)
                .FirstOrDefault();
        }

        public ProjectCreator CreateProjectCreator(ProjectCreatorOption projectCreatortOption)  //ok
        { 
            ProjectCreator projectCreator = new ProjectCreator
            {
                FullName = projectCreatortOption.FullName,
                Address = projectCreatortOption.Address,
                Email = projectCreatortOption.Email,
                Phone = projectCreatortOption.Phone
            };
            db.ProjectCreators.Add(projectCreator);
            db.SaveChanges();

            return projectCreator; 
        }

        public ProjectCreator FindProjectCreator(int projectCreatorId)  //ok
        { 
            return db.ProjectCreators.Find(projectCreatorId); 
        }

        public List<Project> ShowProjectsByCreator(int projectCreatorId)    //ok
        {
            ProjectCreator projectCreator = db.ProjectCreators.Find(projectCreatorId);
            return db.Projects
                .Where(project => project.ProjectCreator == projectCreator)
                .ToList();
        }

        public List<Project> ShowFundingProjectsByCreator(int projectCreatorId)     //ok
        {
            ProjectCreator projectCreator = db.ProjectCreators.Find(projectCreatorId);
            return db.Projects
                .Where(project => project.ProjectCreator == projectCreator)
                .Where(project => project.TotalFundings > 0)
                .ToList(); 
        }

        public Project PostStatusUpdate(int projectId, string statusUpdate)     //ok
        { 
            Project project = db.Projects.Find(projectId);
            project.StatusUpdate = statusUpdate;
            db.SaveChanges();
            return project; 
        }

        public FundingPackage AddFundingPackage(int projectId, FundingPackageOption fundingPackageOption)   //ok
        { 
            Project project = db.Projects.Find(projectId);
            FundingPackageManagment fundingPackageManager = new FundingPackageManagment(db); 
            FundingPackage fundingPackage = fundingPackageManager.CreateFundingPackage(fundingPackageOption);
            project.FundingPackages.Add(fundingPackage);

            db.SaveChanges();
            return fundingPackage; 
        }
    }
}
