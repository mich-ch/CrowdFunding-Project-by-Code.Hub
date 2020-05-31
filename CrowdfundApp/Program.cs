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



            using CrmDbContext db = new CrmDbContext();

            IProjectManager projectMng = new ProjectManagment(db);
            IProjectCreatorManager projCrMng = new ProjectCreatorManagment(db);
            IBackerManager backerMangr = new BackerManagment(db);
            IFundingPackageManager fundMangr = new FundingPackageManagment(db);


            ProjectCreatorOption projectCreatorOption = new ProjectCreatorOption
            {
                FullName = "Stelios",
                Address = "SKG",
                Email = "email"
            };
            ProjectCreator projectCreator = projCrMng.CreateProjectCreator(projectCreatorOption);

            BackerOption backerOpt = new BackerOption()
            {
                FullName = "mixalis",
                Address = "ptolem",
                Email = "email@email.com",
                Phone = "12345"
            };

            ProjectOption projectOption = new ProjectOption
            {
                ProjectCreatorId = 1,
                Title = "B",
                Description = "description B",
                StatusUpdate = "status B",
                TotalFundings = 0m,
                Goal = 1000m,
                Category = "Fashion",
                Active = true

            };



            FundingPackageOption fundOpt = new FundingPackageOption
            {
                Price = 158,
                Reward = "nadd",
                ProjectId = 2
            };

            //Backer backer = backerMangr.CreateBacker(backerOpt);
            //Project project = projectMng.CreateProject(projectOption);
            FundingPackage funding = projCrMng.AddFundingPackage(fundOpt);

            //Console.WriteLine(
            //          $"Id= {backer.Id} Address= {backer.Address} Email= {backer.Email}  ");

            //Console.WriteLine(
            //          $"Id= {project.Id} Description= {project.Description} StatusUpdate= {project.StatusUpdate}  ");

            //Console.WriteLine(
            //          $"Id= {funding.Id} Reward= {funding.Reward} ");

           // BackerFundingPackage bfp = backerMangr.Fund(funding, 1);
            //BackerFundingPackage bfp2 = backerMangr.Fund(2, 2, 1);
            //BackerFundingPackage bfp3 = backerMangr.Fund(3, 2, 1);

            //Console.WriteLine(
            //          $"Id= {bfp.Id} Backer= {bfp.Backer.Id} FundingPackage= {bfp.FundingPackage.Id}  ");

            List<BackerFundingPackage> bfps = backerMangr.ShowFundingPackageByBacker(1);
            foreach (var bfp in bfps)
            {
                Console.WriteLine(
                         $"Title= {bfp.Backer} TotalFundings= {bfp.Project} Goal= {bfp.Id}  ");

            }

        }
    }
}
