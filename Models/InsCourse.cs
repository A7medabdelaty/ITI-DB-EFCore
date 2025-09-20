namespace ITI_DB.Models
{
    public class InsCourse
    {
        public int InsId { get; set; }

        public int CrsId { get; set; }

        public string? Evaluation { get; set; }

        public Instructor Instructor { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
