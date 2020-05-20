using CrowdfundApp.Models;
using CrowdfundApp.Options;
using System;
using System.Collections.Generic;
using System.Text;


namespace CrowdfundApp.Services
{
    public interface IFundingPackagesManager
    {
        FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption);
        FundingPackage FindFundingPackage(int FundingsPackagesId);
    }
}
