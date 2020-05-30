using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrowdfundMvc.Models;
using CrowdfundApp.Database;
using CrowdfundApp.Services;
using CrowdfundApp.Models;

namespace CrowdfundMvc.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly CrmDbContext db;
        private IBackerManager backermanager;
        private IFundingPackageManager fundingPackageManager;
        private IProjectCreatorManager projectCreatorManager;
        private IProjectManager projectManager;

        public HomeController(ILogger<HomeController> _logger, CrmDbContext _db,
                              IBackerManager _backermanager, 
                              IFundingPackageManager _fundingPackageManager, 
                              IProjectCreatorManager _projectCreatorManager, 
                              IProjectManager _projectManager)
        {
            logger = _logger;
            db = _db;
            backermanager = _backermanager;
            fundingPackageManager = _fundingPackageManager;
            projectCreatorManager = _projectCreatorManager;
            projectManager = _projectManager;
        }

        [HttpGet("")]
        public IActionResult Home()
        {
            return View("Index");
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("AddProjectCreator")]
        public IActionResult AddProjectCreator()
        {
            return View();
        }

        [HttpGet("ProfileProjectCreator")]
        public IActionResult ProfileProjectCreator([FromQuery] int projectCreatorId)
        {
            ProjectCreator projectCreator = projectCreatorManager.FindProjectCreator(projectCreatorId);
            ProjectCreatorModel pj = new ProjectCreatorModel
            {
                ProjectCreatorId = projectCreatorId,
                FullName=projectCreator.FullName,
                Address=projectCreator.Address,
                Phone=projectCreator.Phone,
                Email=projectCreator.Email
            };

            return View(pj);
        }


        [HttpGet("ProfileBacker")]
        public IActionResult ProfileBacker([FromQuery] int backerId)
        {
            Backer backer = db.Backers.Find(backerId); 
            BackerModel ba = new BackerModel 
            {
                BackerId = backerId,
                FullName = backer.FullName,
                Address = backer.Address,
                Phone = backer.Phone,
                Email = backer.Email
            };

            return View(ba);
        }


        [HttpGet("AddBacker")]
        public IActionResult AddBacker()
        {
            return View();
        }

        [HttpGet("AddProject")]
        public IActionResult AddProject([FromQuery] int  projectCreatorId)
        {
            ProjectCreatorModel pj = new ProjectCreatorModel
            {
                ProjectCreatorId = projectCreatorId
            };

            return View(pj);
        }

        [HttpGet("Projects")]
        public IActionResult Projects()
        {
            ProjectModel allProjects = new ProjectModel
            {
                Projects = backermanager.ShowAllProjects()
            };
            return View(allProjects);
        }

        [HttpGet("TrendsProjects")]
        public IActionResult TrendsProjects()
        {
            ProjectModel allProjects = new ProjectModel
            {
                Projects = backermanager.ShowTrendsProjects()
            };
            return View(allProjects);
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("LoginBacker")]
        public IActionResult LoginBacker()
        {
            return View();
        }


        [HttpGet("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
