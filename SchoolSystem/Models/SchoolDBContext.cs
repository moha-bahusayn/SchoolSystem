using System.Data.Entity;

namespace SchoolSystem.Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("SchoolDB")
        {
            Database.SetInitializer(new SchoolDBInitializer());
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            //DatabaseInitializer.Seed();
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}