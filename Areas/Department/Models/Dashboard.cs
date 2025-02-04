using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrialMVCWebApp.Areas.Department.Models
{
    public class Department
    {
        //Generates random string for id, cannot be changed.
        public string id { get; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string manager { get; set; }
        public string location { get; set; }
        public int employeeCount { get; set; }
    }
}