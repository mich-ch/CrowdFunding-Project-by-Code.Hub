using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class Multimedia
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Path { get; set; }
        public bool IsPhoto { get; set; }
        public bool IsVideo { get; set; }

    }
}
