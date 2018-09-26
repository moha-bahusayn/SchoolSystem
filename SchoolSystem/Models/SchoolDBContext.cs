using System.Data.Entity;

namespace SchoolSystem.Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("SchoolDB")
        {
            Database.Initialize(true);
            Database.SetInitializer(new SchoolDBInitializer());
            Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());
            //DatabaseInitializer.Seed();
        }

        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        //public static SchoolDBContext Create()
        //{
        //    return new SchoolDBContext();
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Classroom>().ToTable("Classrooms");
        //    modelBuilder.Entity<Subject>().ToTable("Subjects");
        //    modelBuilder.Entity<Student>().ToTable("Students");
        //    modelBuilder.Entity<Instructor>().ToTable("Instructors");
        //}

        //public DbQuery<T> Query<T>() where T : class
        //{
        //    return Set<T>().AsNoTracking();
        //}
    }
}