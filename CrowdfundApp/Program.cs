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
                Title = "A",
                Description = "description A",
                StatusUpdate = "status A",
                TotalFundings = 0m,
                Goal = 1000m,
                Category = "sports",
                Active = true

            };

            ProjectOption projectOption2 = new ProjectOption
            {
                ProjectCreatorId = 22,
                Title = "A",
                Description = "description A",
                StatusUpdate = "status A",
                TotalFundings = 0m,
                Goal = 1000m,
                Category = "sports",
                Active = true

            };
            Project project2 = projectMng.CreateProject(projectOption2);

            FundingPackageOption fundOpt = new FundingPackageOption
            {
                Price = 222,
                Reward = "dsadsa",
                ProjectId = 1
            };

            Backer backer = backerMangr.CreateBacker(backerOpt);
            Project project = projectMng.CreateProject(projectOption);
            FundingPackage funding = projCrMng.AddFundingPackage(1, fundOpt);

            Console.WriteLine(
                      $"Id= {backer.Id} Address= {backer.Address} Email= {backer.Email}  ");

            Console.WriteLine(
                      $"Id= {project.Id} Description= {project.Description} StatusUpdate= {project.StatusUpdate}  ");

            Console.WriteLine(
                      $"Id= {funding.Id} Reward= {funding.Reward} ");

            BackerFundingPackage bfp = backerMangr.Fund(1, 1, 1);
            BackerFundingPackage bfp2 = backerMangr.Fund(2, 2, 1);
         
            //Console.WriteLine(
            //          $"Id= {bfp.Id} Backer= {bfp.Backer.Id} FundingPackage= {bfp.FundingPackage.Id}  ");

            List<Project> projectsss = backerMangr.ShowFundingProjectsByBacker(1);
            foreach (var projecttttt in projectsss)
            {
                Console.WriteLine(
                         $"Title= {projecttttt.Title} TotalFundings= {projecttttt.TotalFundings} Goal= {projecttttt.Goal}  ");

            }

        }
    }
}
