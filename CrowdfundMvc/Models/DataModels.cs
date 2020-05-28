using CrowdfundApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdfundMvc.Models
{
    public class ProjectModel
    {
        public List<Project> Projects { get; set; }
    }
    public class ProjectCreatorModel
    {
        public int ProjectCreatorId { get; set; }
    }
}
