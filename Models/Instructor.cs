namespace ITI_DB.Models
{
    public class Instructor
    {
        public int InsId { get; set; }
        public string? InsName { get; set; }

        public string? InsDegree { get; set; }

        public decimal? Salary { get; set; }

        public int? DeptId { get; set; }

        public Department Department { get; set; } = null!;

        public Department ManageDepartment { get; set; } = null!;

        public ICollection<InsCourse> InsCourses { get; set; } = new HashSet<InsCourse>();
    }
}
