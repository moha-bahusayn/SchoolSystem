﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Hobbies { get; set; } //hobbies += ", "+txtNewhobby.text;

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }

        //public int Age { get => DateTime.Now.Year - DateOfBirth.Year; set { } }

        public ICollection<Subject> Subjects { get; set; }
        public Classroom Classroom { get; set; }
    }
}