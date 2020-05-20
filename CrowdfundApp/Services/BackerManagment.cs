using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrowdfundApp.Services
{
    public class BackerManagment: IBackerManager
    {
        private CrmDbContext db;

        public BackerManagment(CrmDbContext _db)
        {
            db = _db;
        }



    }
}
