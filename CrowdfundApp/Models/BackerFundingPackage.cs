using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class BackerFundingPackage 
    {
        public int Id { get; set; }
        public Backer Backer { get; set; }
        public FundingPackage FundingPackage { get; set; }

    }
}
