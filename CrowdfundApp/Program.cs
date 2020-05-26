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
            //// Projects
            ////public List<FundingPackage> ShowFundingPackages()
            ///
            //ProjectOption projectOption = new ProjectOption
            //{
            //    ProjectCreatorId = 1,
            //    Title = "A",
            //    Description = "description A",
            //    StatusUpdate = "status A",
            //    TotalFundings = 0m,
            //    Goal = 1000m,
            //    Category = "sports",
            //    Active = true

            //};
            //using CrmDbContext db = new CrmDbContext();
            //ProjectManagment projectManagement= new ProjectManagment(db);
            //Project project = projectManagement.CreateProject(projectOption);

            //Console.WriteLine(
            //   $"Id= {project.Id} ProjectCreatorId= {project.ProjectCreatorId} Title= {project.Title} ");


            IProjectManager projectMng = new ProjectManagment(db);
            IProjectCreatorManager projCrMng = new ProjectCreatorManagment(db);
            IBackerManager backerMangr = new BackerManagment(db);


            // Backer
            //public List<Project> TextProjectsSearch(string projectTitle)
            //public List<BackerProject> ShowFundingProjectsByBacker(int backerId)
            //public List<Project> ShowProjectsByCategory(string category)
            //public List<Project> ShowTrendsProjects()
            //public void Fund(int projectId, int fundingPackageId)


            //using CrmDbContext db = new CrmDbContext();
            //BackerOption backerOpt = new BackerOption()
            //    {
            //        FullName = "mixalis",
            //        Address = "ptolem",
            //        Email = "email@email.com",
            //        Phone = "12345"
            //    };

            //    IBackerManager backerMangr = new BackerManagment(db);
            //    Backer backer = backerMangr.CreateBacker(backerOpt);
            //    Console.WriteLine(
            //        $"Id= {backer.Id} Name= {backer.FullName} Address= {backer.Address}");


            //ShowProjectsByCategory
            //using CrmDbContext db = new CrmDbContext();
            //IBackerManager backerMangr = new BackerManagment(db);
            //List<Project> projectByCat = backerMangr.ShowProjectsByCategory("sports");
            //foreach (var project in projectByCat)
            //{
            //        Console.WriteLine(
            //           $"Id= {project.Id} ProjectCreatorId= {project.ProjectCreatorId} Title= {project.Title} Category= {project.Category} ");
            //}


            Backer backer = backerMangr.CreateBacker(backerOpt);
            Project project = projectMng.CreateProject(projectOption);
            FundingPackage funding = projCrMng.AddFundingPackage(1, fundOpt);

            Console.WriteLine(
                      $"Id= {backer.Id} Address= {backer.Address} Email= {backer.Email}  ");

            Console.WriteLine(
                      $"Id= {project.Id} Description= {project.Description} StatusUpdate= {project.StatusUpdate}  ");

            Console.WriteLine(
                      $"Id= {funding.Id} Reward= {funding.Reward} ");



            //    // Project Creator
            //    //public ProjectCreator CreateProjectCreator(ProjectCreatorOption projectCreatortOption)
            //    ProjectCreatorOption projCreator = new ProjectCreatorOption()
            //    {
            //        FullName = "fd",
            //        Address = "df",
            //        Email = "email@email.com",
            //        Phone = "432432"
            //    };

        }
    }
}
