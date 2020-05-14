using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class Funding
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Reward { get; set; }
    }
}
