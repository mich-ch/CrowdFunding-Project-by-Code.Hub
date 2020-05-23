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


            ////ShowProjectsByCreator
            //using CrmDbContext db = new CrmDbContext();
            //IProjectCreatorManager creatorMangr = new ProjectCreatorManagment(db);
            //List<Project> projects = creatorMangr.ShowProjectsByCreator(1);
            //foreach (var project in projects)
            //{
            //    Console.WriteLine(
            //    $"ProjectCreatorId= {project.ProjectCreatorId} Title= {project.Title} ");
            //}


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





            // Fundings
            //public FundingPackage CreateFundingPackage(FundingPackageOption fundingPackageOption) 
            //public FundingPackage FindFundingPackage(int FundingsPackageId)



            //    // Project Creator
            //    //public ProjectCreator CreateProjectCreator(ProjectCreatorOption projectCreatortOption)
            //    ProjectCreatorOption projCreator = new ProjectCreatorOption()
            //    {
            //        FullName = "fd",
            //        Address = "df",
            //        Email = "email@email.com",
            //        Phone = "432432"
            //    };

            //    IProjectCreatorManager creatorMangr = new ProjectCreatorManagment(db);
            //    ProjectCreator creator = creatorMangr.CreateProjectCreator(projCreator);
            //    Console.WriteLine(
            //        $"Id= {creator.Id} Name= {creator.FullName} Address= {creator.Address}");
            //    //public ProjectCreator FindProjectCreator(int projectCreatorId) 
            //    ProjectCreator creator2 = creatorMangr.FindProjectCreator(1);
            //    Console.WriteLine(
            //        $"Id= {creator2.Id} Name= {creator2.FullName} Address= {creator2.Address}");
            //    //public List<Project> ShowProjectsByCreator(int projectCreatorId)
            //    List<Project> projects = creatorMangr.ShowProjectsByCreator(1);
            //    //public List<Project> ShowFundingProjectsByCreator(int projectCreatorId) 
            //    //public string PostStatusUpdate(int projectId) 
            //    //public bool AddFundingPackage(int projectId, FundingPackageOption fundingPackageOption)
        }
    }
}
