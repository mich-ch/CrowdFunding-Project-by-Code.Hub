using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int ProjectCreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Multimedia> Multimedia { get; set; }
        public string StatusUpdate { get; set; }
        public List<FundingPackage> FundingPackages { get; set; }
        public decimal TotalFundings { get; set; }
        public decimal Goal { get; set; }
        public string Category { get; set; }
        public bool Active { get; set; }
        public List<BackerProject> BackerProjects { get; set; }


    }
}
