using Microsoft.AspNetCore.Mvc;
using WebAppTask.Data1;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        studDbContext context=new studDbContext();
        public IActionResult Index()
        {
            var Employee= context.Employees.ToList();
            return View("Index",Employee);
        }
    }
}
