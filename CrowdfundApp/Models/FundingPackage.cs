using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class FundingPackage
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        //public int ProjectId { get; set; }
        public decimal Price { get; set; }
        public string Reward { get; set; }
        public List<BackerFundingPackage> BackerFundingPackages { get; set; }
    }
}
