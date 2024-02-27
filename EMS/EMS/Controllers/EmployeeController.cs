using EMS.Models;
using EMS.Services.Implementation;
using EMS.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{

    public class EmployeeController : Controller
    {
        public readonly IEmployeeInfoService _iEmployeeInfoService;

        public EmployeeController(IEmployeeInfoService iEmployeeInfoService) { 
        this._iEmployeeInfoService = iEmployeeInfoService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DisplayData()
        {
            EmployeeInfoViewModel employeeViewModel = new EmployeeInfoViewModel();
            employeeViewModel.EmployeeList = _iEmployeeInfoService.GetEmployeeList();
            return View(employeeViewModel);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeInfoViewModel model)
        {
            _iEmployeeInfoService.SaveEmployee(model);
             return View();
        }

    }
}
