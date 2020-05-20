using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrowdfundApp.Services
{
    public class ProjectCreatorManagment: IProjectCreatorManager
    {
        private CrmDbContext db;

        public ProjectCreatorManagment(CrmDbContext _db)
        {
            db = _db;
        }


    }
}
