namespace ITI_DB.Models
{
    public class Student
    {
        public int StId { get; set; }
        public string? StFname { get; set; }
        public string? StLname { get; set; }

        public string? StAddress { get; set; }

        public int? StAge { get; set; }

        public int? DeptId { get; set; }

        public int? StSuper { get; set; }

        public ICollection<StudCourse> StudCourses { get; set; } = new HashSet<StudCourse>();

        public Department Department { get; set; } = null!;
    }
}
