using EMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    public class SetupDepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DepCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepCreate(SetupDepartmentViewModel model)
        {

            return View();
        }
    }

}
