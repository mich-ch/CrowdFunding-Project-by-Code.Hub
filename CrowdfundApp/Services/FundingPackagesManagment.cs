using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrowdfundApp.Services
{
    public class FundingPackagesManagment: IFundingPackagesManager
    {
        private CrmDbContext db;

        public FundingPackagesManagment(CrmDbContext _db)
        {
            db = _db;
        }


    }
}
