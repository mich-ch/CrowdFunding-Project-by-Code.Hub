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

        public Backer CreateBacker(BackerOption backerOption) { return (null); }
        public List<Project> TextProjectsSearch(string projectName) { return (null); }
        public List<Project> ShowFundingProjectsByBacker(int backerId) { return (null); }
        public void Fund(int projectId, int fundingPackageId) { }

    }
}
