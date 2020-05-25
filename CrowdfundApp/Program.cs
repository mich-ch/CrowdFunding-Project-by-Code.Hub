using CrowdfundApp.Database;
using CrowdfundApp.Models;
using CrowdfundApp.Options;
using CrowdfundApp.Services;
using System;
using System.Collections.Generic;

namespace CrowdfundApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // Project Creator
            using CrmDbContext db = new CrmDbContext();
            ProjectCreatorOption projectCreatorOption = new ProjectCreatorOption()
            {
                FullName = "Thanos",
                Address = "Serres",
                Email = "thanos@email.com",
                Phone = "432432"
            };

            IProjectCreatorManager projectCreatorManager = new ProjectCreatorManagment(db);
            ProjectCreator projectCreator = projectCreatorManager.CreateProjectCreator(projectCreatorOption);
            Console.WriteLine(
                $"Id= {projectCreator.Id} Name= {projectCreator.FullName} Address= {projectCreator.Address}");


            // Projects
            ProjectOption projectOption = new ProjectOption
            {
                ProjectCreatorId = 4,
                Title = "Thanos project",
                Description = "description Thanos",
                StatusUpdate = "status Thanos",
                TotalFundings = 0m,
                Goal = 1000m,
                Category = "graficts",
                Active = true

            };

            ProjectManagment projectManagment = new ProjectManagment(db);
            Project project = projectManagment.CreateProject(projectOption);


            FundingPackageOption fundingPackageOption = new FundingPackageOption
            {
                Price = 5,
                Reward = "mpananes",
                ProjectId = 2
            };

            FundingPackageManagment fundingPackageManagment = new FundingPackageManagment(db);
            FundingPackage fundingPackage = fundingPackageManagment.CreateFundingPackage(fundingPackageOption);


           // Backer
            BackerOption backerOption = new BackerOption()
            {
                FullName = "mixalis",
                Address = "ptolem",
                Email = "mixalis@email.com",
                Phone = "012345"
            };

            BackerManagment backerManagment = new BackerManagment(db);
            Backer backer = backerManagment.CreateBacker(backerOption);


            //φτιάξε BackerFundingPackage
            //κλήση της Fund



        }



    }
}
