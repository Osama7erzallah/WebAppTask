using Microsoft.AspNetCore.Mvc;
using WebAppTask.Data1;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            studDbContext context = new studDbContext();
            var Student = context.Students.ToList();
            return View("Index",Student);
        }
    }
}
