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
        public int ProjectCreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusUpdate { get; set; }
        public decimal TotalFundings { get; set; }
        public decimal Goal { get; set; }
        public string Category { get; set; }
        public bool Active { get; set; }
    }
    public class ProjectCreatorModel
    {
        public int ProjectCreatorId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class ProjectOptModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusUpdate { get; set; }
        public decimal Goal { get; set; }
        public string Category { get; set; }
        
    }

    public class BackerModel
    {
        public int BackerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }


   

}
