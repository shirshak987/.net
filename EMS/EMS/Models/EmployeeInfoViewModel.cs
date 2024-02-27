using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class EmployeeInfoViewModel
    {
        [Required]
        public string FirstName {  get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int? Gender {  get; set; }
        public string Address { get; set; } = string.Empty; 
        public string ProfileImagePath {  get; set; } = string.Empty;

        public List<EmployeeInfoViewModel> EmployeeList { get; set; }
       
        public EmployeeInfoViewModel() 
        {
            EmployeeList = new List<EmployeeInfoViewModel>();
        }
    }
}
