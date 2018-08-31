using System.Data.Entity;

namespace SchoolSystem.Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("name=DBConnect")
        {
            Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}