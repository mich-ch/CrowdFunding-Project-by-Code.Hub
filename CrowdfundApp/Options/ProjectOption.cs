using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Options
{
    public class ProjectOption
    {
        public int ProjectCreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusUpdate { get; set; }
        public decimal TotalFundings { get; set; }
        public decimal? Goal { get; set; }
        public string Category { get; set; }
        public bool Active { get; set; }
    }
}
