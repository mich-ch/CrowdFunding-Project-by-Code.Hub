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
        

        public ApiProjectCreatorController(IProjectCreatorManager _projectCreatorManager)
        {
            projectCreatorManager = _projectCreatorManager;
        }

        [HttpPost]
        public ProjectCreator AddProjectCreator ([FromBody] ProjectCreatorOption projectCreatorOption)
        {
            return projectCreatorManager.CreateProjectCreator(projectCreatorOption);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
