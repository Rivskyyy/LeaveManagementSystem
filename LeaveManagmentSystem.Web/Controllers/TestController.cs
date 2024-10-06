using LeaveManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagmentSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(2000,05,09)

            };

            return View(data);
        }
    }
}
