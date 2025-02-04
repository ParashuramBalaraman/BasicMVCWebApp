using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialMVCWebApp.Areas.Department.Models;

namespace TrialMVCWebApp.Areas.Department.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Department/Dashboard
        //Action method that returns the Index view with a list of departments
        public ActionResult Index()
        {
            var model = new DashboardViewModel
            {
                Departments = new List<Models.Department>
                {
                new Models.Department { name = "HR", manager = "Jane Dean", location = "New York", employeeCount = 10 },
                new Models.Department { name = "IT", manager = "Terrence Earl", location = "Los Angeles", employeeCount = 20 },
                new Models.Department { name = "Finance", manager = "Bill Davids", location = "Chicago", employeeCount = 15 }
                }
            };
            return View(model);
        }
    }
}