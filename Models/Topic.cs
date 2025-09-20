namespace ITI_DB.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string? TopicName { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
    }
}
