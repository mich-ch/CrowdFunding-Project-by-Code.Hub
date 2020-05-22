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

        public Project CreateProject(ProjectOption projectOption) { return (null); }
        public Project FindProject(int projectId){ return (null);}
        public List<FundingPackage> ShowFundingPackages() { return (null); }


        
    }
}
