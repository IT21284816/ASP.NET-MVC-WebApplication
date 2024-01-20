using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_WebApplication.Controllers
{
    public class EmployeesController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
