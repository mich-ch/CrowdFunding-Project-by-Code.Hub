using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public List<string> Videos { get; set; }
        public string StatusUpdate { get; set; }
        public List<Funding> FundingChoices { get; set; }
        public decimal TotalFundings { get; set; }
        public decimal Goal { get; set; }
        public bool Active { get; set; }


    }
}
