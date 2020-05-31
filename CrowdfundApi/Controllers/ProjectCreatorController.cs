using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdfundApp.Models;
using CrowdfundApp.Options;
using CrowdfundApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrowdfundApi.Controllers
{
    [ApiController]
    [Route("[controller]/projectcreator")]
    public class ProjectCreatorController : ControllerBase
    {
        

        private readonly ILogger<ProjectCreatorController> _logger;
        private readonly IProjectCreatorManager projCreatorMangr;


        public ProjectCreatorController(ILogger<ProjectCreatorController> logger, IProjectCreatorManager _projCreatorMng)
        {
            _logger = logger;
            projCreatorMangr = _projCreatorMng;
        }

        [HttpGet("")]   //ok
        public string Get()
        {
            return "Welcome to our site";
        }

        [HttpPost("")]  //ok
        public ProjectCreator PostProjectCreator(ProjectCreatorOption projectCreatortOption)
        {
            return projCreatorMangr.CreateProjectCreator(projectCreatortOption);
        }

        [HttpGet("{projectCreatorId}")] //ok
        public ProjectCreator GetProjectCreator(int projectCreatorId)
        {
            return projCreatorMangr.FindProjectCreator(projectCreatorId);
        }

        [HttpGet("projects/{id}")]  //ok
        public List<Project> GetAllProjectsCreator(int projectCreatorId)
        {
            return projCreatorMangr.ShowProjectsByCreator(projectCreatorId);
        }

        [HttpGet("fundingprojects/{id}")]
        public List<Project> GetAllFundingProjectsCreator(int projectCreatorId)
        {
            return projCreatorMangr.ShowFundingProjectsByCreator(projectCreatorId);
        }


        //update
        [HttpPost("project/{projectId}/status/{statusUpdate}")]
        public Project PostStatusUpdate(int projectId, string statusUpdate)
        {
            return projCreatorMangr.PostStatusUpdate(projectId, statusUpdate);
        }


        
       
    }
}
