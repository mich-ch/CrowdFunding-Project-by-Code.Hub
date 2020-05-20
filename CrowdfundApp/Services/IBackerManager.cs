using CrowdfundApp.Models;
using CrowdfundApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Services
{
    public interface IBackerManager
    {
        Backer CreateBacker(BackerOption backerOption);
        List<Project> TextProjectsSearch(string projectName);
        List<Project> ShowFundingProjectsByBacker(int backerId);
        void Fund(int projectId, int fundingPackageId);
        List<FundingPackage> SelectProjectToFund(int projectId);
        string SelectFundingPackage(int fundingPackageId);
    }
}
