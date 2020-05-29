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
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    
}
