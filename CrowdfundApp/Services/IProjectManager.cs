using CrowdfundApp.Models;
using CrowdfundApp.Options;
using System;
using System.Collections.Generic;
using System.Text;


namespace CrowdfundApp.Services
{
    public interface IProjectManager
    {
        public Project CreateProject(ProjectOption projectOption);
        List<FundingPackage> ShowFundingPackages(int projectId);
        Project FindProjectById(int projectId);
        Project Update(ProjectOption projOption, int projectId);
        Project FindCreatorbyProject(int projectid);
    }
}
