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
    [ApiController]
    [Route("[controller]")]
    public class ApiBackerController : Controller
    {
        private IBackerManager backerManager;
        public ApiBackerController(IBackerManager _backerManager )
        {
            backerManager = _backerManager;
        }

        [HttpPost("addbacker")]
        public Backer AddBacker([FromBody] BackerOption backerOption)
        {
            return backerManager.CreateBacker(backerOption);
        }

        [HttpPost("addbackerfundingpackage")]
        public BackerFundingPackage Addbackerfundingpackage([FromBody] BackerFundingPackagetOption bfpO)
        {
            FundingPackage fundPack = backerManager.ShowFundingPackageById(bfpO.FundingPackageId);
            return backerManager.Fund(fundPack, bfpO.BackerId, bfpO.ProjectId);
        }


        [HttpPost("loginBacker")]
        public Backer LoginBacker([FromBody] BackerOption backerOption)
        {
            return backerManager.FindBackerByEmail(backerOption);

        }

    }
}
