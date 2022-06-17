using EntityFrameworkCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            using var employeeContext = new EmployeeContext();
            var data = employeeContext.Jobs.Include("Department").ToList();
            return View(data);
        }
    }
}
