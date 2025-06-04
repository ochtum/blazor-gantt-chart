using System;
using System.Collections.Generic;

namespace GanttChartApp.Models
{
    public class GanttTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Assignee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Progress { get; set; } // 0-100
    }
}
