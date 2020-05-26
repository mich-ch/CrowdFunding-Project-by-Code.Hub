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
        public Project PostStatusUpdate(int projectId, string statusUpdate);
        FundingPackage AddFundingPackage(int projectId, FundingPackageOption fundingPackageOption); //FundingPackage


    }

}
