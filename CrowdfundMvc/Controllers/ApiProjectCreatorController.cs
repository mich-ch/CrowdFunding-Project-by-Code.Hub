using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CrowdfundApp.Models;
using CrowdfundApp.Options;
using CrowdfundApp.Services;
using CrowdfundMvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CrowdfundMvc.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ApiProjectCreatorController : Controller
    {
        private IProjectCreatorManager projectCreatorManager; 
        private IProjectManager projectManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public ApiProjectCreatorController(IProjectCreatorManager _projectCreatorManager, 
                                           IProjectManager _projectManager, IWebHostEnvironment _hostingEnvironment)
        {
            projectCreatorManager = _projectCreatorManager;
            projectManager = _projectManager;
            hostingEnvironment = _hostingEnvironment;
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

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        [HttpPost("addproject")]
        public int AddProject([FromForm] ProjectOption projectOption)
        {
            // do other validations on your model as needed
            if (projectOption.Picture != null)
            {
                var uniqueFileName = GetUniqueFileName(projectOption.Picture.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "Images");
                var filePath = Path.Combine(uploads, uniqueFileName);
                projectOption.Picture.CopyTo(new FileStream(filePath, FileMode.Create));


                projectOption.PicturePath = "/Images/" + uniqueFileName;
                //to do : Save uniqueFileName  to your db table   
            }
            
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
