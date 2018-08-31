using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Models
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }
}