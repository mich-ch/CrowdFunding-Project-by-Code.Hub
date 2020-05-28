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
    //[ApiController]
    //[Route("[controller]")]   na ginei controller gia to login
    public class ApiBackerController : Controller
    {
        private IBackerManager backerManager;


        public ApiBackerController(IBackerManager _backerManager )
        {
            backerManager = _backerManager;
        }

        [HttpPost]
        public Backer AddBacker([FromBody] BackerOption backerOption)
        {
            return backerManager.CreateBacker(backerOption);
        }

        [HttpPost("login")]   
        public Backer LoginBacker([FromBody] BackerOption backOpt)
        {
            return backerManager.FindBackerByEmail(backOpt);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
