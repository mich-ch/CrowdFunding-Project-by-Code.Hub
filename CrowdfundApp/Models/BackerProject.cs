﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdfundApp.Models
{
    public class BackerProject
    {
        public int Id { get; set; }
        public Backer Backer { get; set; }
        public Project Project { get; set; }
    }
}
