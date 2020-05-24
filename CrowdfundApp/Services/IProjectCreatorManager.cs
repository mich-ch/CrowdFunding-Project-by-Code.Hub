using CrowdfundApp.Models;
using CrowdfundApp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Services
{
    public interface IProjectCreatorManager
    {
        ProjectCreator CreateProjectCreator(ProjectCreatorOption projectCreatortOption);
        ProjectCreator FindProjectCreator(int projectCreatorId);
        List<Project> ShowProjectsByCreator(int projectCreatorId);
        List<Project> ShowFundingProjectsByCreator(int projectCreatorId);
        public string PostStatusUpdate(int projectId, string statusUpdate);
        bool AddFundingPackage(int projectId, FundingPackageOption fundingPackageOption); //FundingPackage


    }

}
