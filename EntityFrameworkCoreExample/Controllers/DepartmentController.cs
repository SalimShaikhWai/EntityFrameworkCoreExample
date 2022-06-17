using EntityFrameworkCoreExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {

            using var employeeContext=new EmployeeContext();
            var data = employeeContext.Departments.Include("Location").ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment(Department department)
        {
            using var employeeContext=new EmployeeContext();
            employeeContext.Departments.Add(department);
            employeeContext.SaveChanges();
            return RedirectToAction("Create");
        }



    }
}
