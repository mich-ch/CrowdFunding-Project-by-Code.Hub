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
        List<Project> TextProjectsSearch(string projectTitle);
        List<BackerFundingPackage> ShowFundingPackageByBacker(int backerId);
        List<Project> ShowAllProjects();
        List<Project> ShowProjectsByCategory(string category);
        List<Project> ShowTrendsProjects();
        Backer FindBackerByEmail(BackerOption backOption);
        BackerFundingPackage Fund(FundingPackage fundingPackage, int backerId, int projectId);
        FundingPackage ShowFundingPackageById(int fundingPackId);

    }
}
