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
        List<FundingPackage> ShowFundingPackageByProjectId(int projectId);
        ProjectCreator FindProjectCreator(int projectCreatorId);
        List<Project> ShowProjectsByCreator(int projectCreatorId);
        List<Project> ShowFundingProjectsByCreator(int projectCreatorId);
        Project PostStatusUpdate(int projectId, string statusUpdate);
        FundingPackage AddFundingPackage(FundingPackageOption fundingPackageOption); //FundingPackage
        ProjectCreator FindProjectCreatorByEmail(ProjectCreatorOption projCreatorOption);
    }

}
