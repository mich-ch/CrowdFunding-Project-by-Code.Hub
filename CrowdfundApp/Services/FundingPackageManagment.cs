using CrowdfundApp.Options;
using CrowdfundApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrowdfundApp.Models;

namespace CrowdfundApp.Services
{
    public class FundingPackageManagment: IFundingPackageManager
    {
        private CrmDbContext db;

        public FundingPackageManagment(CrmDbContext _db)
        {
            db = _db;
        }

        public FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption) { return (null); }
        public FundingPackage FindFundingPackage(int FundingsPackageId) { return (null); }

    }
}
