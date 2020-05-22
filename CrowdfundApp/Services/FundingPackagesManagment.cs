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

        //Create new FundingPackage
        public FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption)
        {
            FundingPackage fundingPackage = new FundingPackage
            {
                Price = fundingPackageOption.Price,
                Reward = fundingPackageOption.Reward,
            };


            db.FundingPackages.Add(fundingPackage);
            db.SaveChanges();

            return fundingPackage;
        }

        //Create FundingPackage by FundingsPackagesId
        public FundingPackage FindFundingPackage(int FundingsPackagesId)
        {
            return db.FundingPackages.Find(FundingsPackagesId);
        }
    }
}
