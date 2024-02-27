namespace EMS.Entities
{
    public class DepartmentInfo : BaseEntity

    {
        public string DepartmentName { get; set; } = string.Empty;
        public int? Display { get; set; }
    }
}
