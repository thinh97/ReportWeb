using System;
using System.Collections.Generic;

namespace Report.Models.Reports
{
    public class Report
    {
        public int UserId { get; set; }

        public IList<Task> Tasks { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
