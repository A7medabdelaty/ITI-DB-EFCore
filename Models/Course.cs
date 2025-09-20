namespace ITI_DB.Models
{
    public class Course
    {
        public int CrsId { get; set; }
        public string? CrsName { get; set; }
        public int? CrsDuration { get; set; }

        public int? TopId { get; set; }

        public Topic Topic { get; set; } = null!;
        public ICollection<StudCourse> StudCourses { get; set; } = new HashSet<StudCourse>();

        public ICollection<InsCourse> InsCourses { get; set; } = new HashSet<InsCourse>();

    }
}
