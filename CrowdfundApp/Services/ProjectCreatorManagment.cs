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

        public ProjectCreator CreateProjectCreator(ProjectCreatorOption projectCreatortOption)
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

        public ProjectCreator FindProjectCreator(int projectCreatorId) 
        { 
            return db.ProjectCreators.Find(projectCreatorId); 
        }

        public List<Project> ShowProjectsByCreator(int projectCreatorId) 
        { 
            return db.Projects
                .Where(project => project.ProjectCreatorId == projectCreatorId)
                .ToList();
        }

        public List<Project> ShowFundingProjectsByCreator(int projectCreatorId) 
        { 
            return db.Projects
                .Where(project => project.ProjectCreatorId == projectCreatorId)
                .Where(project => project.TotalFundings > 0)
                .ToList(); 
        }

        public string PostStatusUpdate(int projectId) 
        { 
            Project project = db.Projects.Find(projectId);

            return project.StatusUpdate; 
        }
        public bool AddFundingPackage(int projectId, FundingPackageOption fundingPackageOption) 
        { 
            Project project = db.Projects.Find(projectId);
            FundingPackageManagment fundingPackageManager = new FundingPackageManagment(db); //help
            FundingPackage fundingPackage = fundingPackageManager.CreateFundingPackage(fundingPackageOption);

            project.FundingPackages.Add(fundingPackage);

            db.SaveChanges();
            return true; 
        }


    }
}
