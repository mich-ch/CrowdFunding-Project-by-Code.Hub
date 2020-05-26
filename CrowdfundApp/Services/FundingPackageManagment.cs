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

        public FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption)   //ok
        {
            FundingPackage fundingPackage = new FundingPackage
            {
                Price = fundingPackageOption.Price,
                Reward = fundingPackageOption.Reward,
                ProjectId = fundingPackageOption.ProjectId
            };
            db.FundingPackages.Add(fundingPackage);
            db.SaveChanges();

            return fundingPackage;
        }
    }
}
