 using EMS.Entities;
using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{

    public class EmployeeInfoService : IEmployeeInfoService
    {
        public EmployeeInfoService()
        {

        }
        public int GetEmployeeById(int employeeId)
        {
            return 1;
        }

        public void SaveEmployee(EmployeeInfoViewModel model)
        {
            EmployeeInfo employeeinfo = new EmployeeInfo();
            employeeinfo.FirstName = model.FirstName;
            employeeinfo.LastName = model.LastName;
            employeeinfo.Email = model.Email;   
            employeeinfo.Phone = model.Phone;
            employeeinfo.Gender = model.Gender;
            employeeinfo.Address = model.Address;
            employeeinfo.ProfileImagePath = model.ProfileImagePath;

        }

        public void DeleteEmployee(int employeeId)
        {
           
        }

        public List<EmployeeInfoViewModel> GetEmployeeList()
        {
            var employeelist = new List<EmployeeInfoViewModel>();
            EmployeeInfoViewModel employeeInfoViewModel = new EmployeeInfoViewModel();
            employeeInfoViewModel.FirstName = "Shirshak";
            employeeInfoViewModel.LastName = "Shrestha";
            employeeInfoViewModel.Address = "Kathmandu";
            employeeInfoViewModel.Email = "shirshak@gmail.com";
            employeeInfoViewModel.Gender = 1;
            employeeInfoViewModel.Phone = "98765643210";
            employeelist.Add(employeeInfoViewModel);

            EmployeeInfoViewModel employeeInfoViewModel1 = new EmployeeInfoViewModel();

            employeeInfoViewModel1.FirstName = "Ram";
            employeeInfoViewModel1.LastName = "Shrestha";
            employeeInfoViewModel1.Address = "Pokhara";
            employeeInfoViewModel1.Email = "Ram@gmail.com";
            employeeInfoViewModel1.Gender = 1;
            employeeInfoViewModel1.Phone = "98765643210";
            employeelist.Add(employeeInfoViewModel1);


            return employeelist;
        }
    }
}
