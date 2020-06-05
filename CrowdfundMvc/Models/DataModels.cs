using CrowdfundApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundMvc.Models
{
    public class ProjectModel
    {
        public int FundingPackageId { get; set; }
        public List<FundingPackage> FundingPackages { get; set; }
        public ProjectCreator ProjectCreator { get; set; }
        public List<Project> Projects { get; set; }
        public int BackerId { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusUpdate { get; set; }
        public decimal TotalFundings { get; set; }
        public decimal Goal { get; set; }
        public string Category { get; set; }
        public int ProjectCreatorId { get; set; }
        public bool Active { get; set; }

        
        public Backer Backer { get; set; }
        public Project Project { get; set; }
        
    }



    public class FundModel
    {
        public List<FundingPackage> FundingPackages { get; set; }
        public Backer Backer { get; set; }
        public Project Project { get; set; }
        public int FundingPackageId { get; set; }
        


    }

    public class ProjectCreatorModel
    {
        public int ProjectCreatorId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Project> Projects { get; set; }
    }

    public class ProjectOptModel
    {
        public int ProjectCreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusUpdate { get; set; }
        public decimal Goal { get; set; }
        public string Category { get; set; }
        
    }

    public class BackerModel
    {
        public List<BackerFundingPackage> backerFundingPackages { get; set; }
        public int BackerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Project> Projects { get; set; }
    }


   

}
