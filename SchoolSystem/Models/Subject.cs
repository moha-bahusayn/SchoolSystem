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

        public enum ScheduleDays { Sun, Mon, Tue, Wed, Thu };

        public ScheduleDays ScheduleDay { get; set; }

        public ICollection<Student> Students { get; set; }
        public Instructor Instructor { get; set; }
    }
}