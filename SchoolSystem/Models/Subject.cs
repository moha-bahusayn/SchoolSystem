using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //public enum ScheduleDay { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

        public ICollection<Student> Students { get; set; }
        public Instructor Instructor { get; set; }
    }
}