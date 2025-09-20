namespace ITI_DB.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }
        public string? DeptDescription { get; set; }
        public string? DeptLocation { get; set; }
        public int? ManagerId { get; set; }
        public DateOnly? ManagerHiredate { get; set; }
        public Instructor Manager { get; set; } = null!;
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}
