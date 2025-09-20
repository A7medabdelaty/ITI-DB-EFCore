using ITI_DB.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_DB.Context
{
    public class ITIContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=New_ITI_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITIContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        #region Tables
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InsCourse> InsCourses { get; set; }
        public DbSet<Department> Departments { get; set; }

        #endregion
    }
}
