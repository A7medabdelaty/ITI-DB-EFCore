namespace ITI_DB.Models
{
    public class StudCourse
    {
        public int CrsId { get; set; }
        public int StId { get; set; }

        public string? Grade { get; set; }

        public Course Course { get; set; } = null!;
        public Student Student { get; set; } = null!;
    }
}
