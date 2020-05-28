using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdfundApp.Models;
using CrowdfundApp.Options;
using CrowdfundApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrowdfundMvc.Controllers
{
    public class ApiProjectCreatorController : Controller
    {

        private IProjectCreatorManager projectCreatorManager; 
        private IProjectManager projectManager; 
        

        public ApiProjectCreatorController(IProjectCreatorManager _projectCreatorManager, IProjectManager _projectManager)
        {
            projectCreatorManager = _projectCreatorManager;
            projectManager = _projectManager;
        }

        [HttpPost]
        public ProjectCreator AddProjectCreator ([FromBody] ProjectCreatorOption projectCreatorOption)
        {
            return projectCreatorManager.CreateProjectCreator(projectCreatorOption);
        }

        [HttpPost]
        public Project AddProject([FromBody] ProjectOption projectOption)
        {
            return projectManager.CreateProject(projectOption);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
