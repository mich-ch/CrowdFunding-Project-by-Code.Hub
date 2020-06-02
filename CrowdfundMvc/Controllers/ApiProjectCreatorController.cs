using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdfundApp.Models;
using CrowdfundApp.Options;
using CrowdfundApp.Services;
using CrowdfundMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrowdfundMvc.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ApiProjectCreatorController : Controller
    {
        private IProjectCreatorManager projectCreatorManager; 
        private IProjectManager projectManager; 
        
        public ApiProjectCreatorController(IProjectCreatorManager _projectCreatorManager, 
                                           IProjectManager _projectManager)
        {
            projectCreatorManager = _projectCreatorManager;
            projectManager = _projectManager;
        }

        [HttpPost("addprojectcreator")]
        public ProjectCreator AddProjectCreator ([FromBody] ProjectCreatorOption projectCreatorOption)
        {
            return projectCreatorManager.CreateProjectCreator(projectCreatorOption);
        }

        [HttpPut("updateproject")]
        public bool Updateproject([FromBody] ProjectModel proj)
        {


            ProjectOption pj = new ProjectOption
            {
                Category = proj.Category,
                ProjectCreatorId = proj.ProjectCreatorId,
                Title = proj.Title,
                Description = proj.Description,
                StatusUpdate = proj.StatusUpdate,
                ProjectId = proj.ProjectId,
                Goal = proj.Goal
            };
            
            projectManager.Update(pj, proj.ProjectId);
            return true;
        }

        [HttpPost("addproject")]
        public int AddProject([FromBody] ProjectOption projectOption)
        {
            return projectManager.CreateProject(projectOption).Id;
        }

        [HttpPost("addpackage")]
        public int AddFundingPackage([FromBody] FundingPackageOption fundingPackageOption)
        {
            return projectCreatorManager.AddFundingPackage(fundingPackageOption).Id;
        }

        [HttpPost("login")]
        public ProjectCreator LoginProjectCreator([FromBody] ProjectCreatorOption projCreatorOpt)
        {
            return projectCreatorManager.FindProjectCreatorByEmail(projCreatorOpt);

        }

    }
}
