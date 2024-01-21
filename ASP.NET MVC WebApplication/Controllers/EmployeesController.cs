using ASP.NET_MVC_WebApplication.Data;
using ASP.NET_MVC_WebApplication.Models;
using ASP.NET_MVC_WebApplication.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_WebApplication.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public EmployeesController(MVCDemoDbContext mvcDemoDbContext)
        {
            this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            var employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                DateOfBirth = addEmployeeRequest.DateOfBirth,
                Department = addEmployeeRequest.Department,


            };

            mvcDemoDbContext.Employees.Add(employee);
            mvcDemoDbContext.SaveChanges();
            return RedirectToAction("Add");

        }

    }
}
