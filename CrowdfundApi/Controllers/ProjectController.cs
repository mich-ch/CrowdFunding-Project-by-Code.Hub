using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdfundApp.Models;
using CrowdfundApp.Options;
using CrowdfundApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrowdfundApi.Controllers
{
    
    [ApiController]
    [Route("projectcreator/project")]

    public class ProjectController : ControllerBase
    {

        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectManager projMangr;

        public ProjectController(ILogger<ProjectController> logger, IProjectManager _projMng)
        {
            _logger = logger;
            projMangr = _projMng;
        }

        [HttpGet("")]   //ok
        public string Get()
        {
            return "Welcome to projects";
        }

        [HttpPost("")]  //ok
        public Project PostProject(ProjectOption projectOption)
        {
            return projMangr.CreateProject(projectOption);
        }

        //public List<FundingPackage> ShowFundingPackages(int projectId)
        [HttpGet("{projectId}")] 
        public List<FundingPackage> GetFundingPackages(int projectId)
        {
            return projMangr.ShowFundingPackages(projectId);
        }

       


    }
}
