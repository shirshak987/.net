using EMS.Models;

namespace EMS.Services.Interface
{
    public interface ISetupDepartmentService
    {
        int GetDepartmentById(int DepartmentId);

        void SaveDepartment(SetupDepartmentViewModel model);

        void DeleteDepartment(int DepartmentId);

    }
}
