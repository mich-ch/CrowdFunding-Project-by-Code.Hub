using CrowdfundApp.Models;
using CrowdfundApp.Options;
using System;
using System.Collections.Generic;
using System.Text;


namespace CrowdfundApp.Services
{
    public interface IFundingPackageManager
    {
        FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption);
    }
}
