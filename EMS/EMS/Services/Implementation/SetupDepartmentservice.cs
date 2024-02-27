using EMS.Models;
using EMS.Services.Interface;

namespace EMS.Services.Implementation
{
    public class SetupDepartmentservice : ISetupDepartmentService
    {
        public SetupDepartmentservice() { }

        public int GetDepartmentById(int DepartmentId)
        {
            return 1;
        }

        public void SaveDepartment(SetupDepartmentViewModel model)
        {

        }

        public void DeleteDepartment(int DepartmentId)
        {

        }
    }
}
