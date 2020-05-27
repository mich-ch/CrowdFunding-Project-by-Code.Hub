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

namespace CrowdfundMvc.Controllers
{
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("AddProjectCreator")]
        public IActionResult AddProjectCreator()
        {
            return View();
        }

        [HttpGet("AddBacker")]
        public IActionResult AddBacker()
        {
            return View();
        }

        [HttpGet("AddProject")]
        public IActionResult AddProject()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
