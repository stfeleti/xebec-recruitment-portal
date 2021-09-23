﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
    public class Job
    {
        public int JobID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Compensation { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime creationDate { get; set; }

    }
}
