using EMS.Models;

namespace EMS.Services.Interface
{
    public interface IEmployeeInfoService
    {
        int GetEmployeeById(int employeeId);
        void SaveEmployee(EmployeeInfoViewModel model);
        void DeleteEmployee(int employeeId);

        List<EmployeeInfoViewModel> GetEmployeeList();

    }
}
    