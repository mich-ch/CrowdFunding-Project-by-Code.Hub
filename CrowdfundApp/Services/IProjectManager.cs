﻿using CrowdfundApp.Models;
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

    }
}
