using EntityFrameworkCoreExample.Models;
using EntityFrameworkCoreExample.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCoreExample.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult EmployeeDeptWise()
        {
            using var employeeContext = new EmployeeContext();

            var data = (from employee in employeeContext.Employees.ToList()
                       join dept in employeeContext.Departments.ToList()
                       on employee.DepartmentRefId equals dept.Id
                       group employee by dept into g
                       select new EmployeeDeptWise
                       {
                          DeptName= g.Key.Name,
                          Employees=g.ToList(),

                       }).ToList();



            return View(data);
        }
    }
}
