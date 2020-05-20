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

        public ProjectCreator CreateProjectCreator(ProjectCreatorOption projectCreatortOption) { return (null); }
        public ProjectCreator FindProjectCreator(int projectCreatorId) { return (null); }
        public List<Project> ShowProjectsByCreator(int projectCreatorId) { return (null); }
        public List<Project> ShowFundingProjectsByCreator(int projectCreatorId) { return (null); }
        public string PostStatusUpdate(int projectId) { return (null); }
        public bool AddFundingPackage(int projectId, FundingPackage funding) { return false; }


    }
}
