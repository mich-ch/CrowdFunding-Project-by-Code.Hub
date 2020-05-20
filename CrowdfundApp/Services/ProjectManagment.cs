using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrowdfundApp.Services
{
    public class ProjectManagment : IProjectManager
    {
        private CrmDbContext db;

        public ProjectManagment(CrmDbContext _db)
        {
            db = _db;




        }
    }
}
