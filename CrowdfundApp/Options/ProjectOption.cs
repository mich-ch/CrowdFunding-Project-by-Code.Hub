﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Options
{
    public class ProjectOption
    {
        public int ProjectId { get; set; }
        public int ProjectCreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StatusUpdate { get; set; }
        public decimal TotalFundings { get; set; }
        public decimal? Goal { get; set; }
        public string Category { get; set; }
        public bool Active { get; set; }
        public IFormFile Picture { set; get; }
        public string PicturePath { get; set; }
    }
}
