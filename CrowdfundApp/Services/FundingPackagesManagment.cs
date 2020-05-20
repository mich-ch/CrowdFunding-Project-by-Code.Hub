using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class FundingPackagesManagment: IFundingPackagesManager
    {
        private CrmDbContext db;

        public FundingPackagesManagment(CrmDbContext _db)
        {
            db = _db;
        }

        public FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption) { return (null); }
        public FundingPackage FindFundingPackage(int FundingsPackagesId) { return (null); }

    }
}
