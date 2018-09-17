using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SchoolSystem.Models
{
    public class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            List<Student> students = new List<Student>
            {
            new Student{
                FirstName ="Alpha",
                LastName ="Bravo",
                MobileNumber ="1122334455",
                EmailAddress ="Alpha@example.com",
                Hobbies ="Football, Running",
                DateOfBirth = new DateTime(2007, 12, 31),
                },

            new Student{
                FirstName ="Charlie",
                LastName ="Delta",
                MobileNumber ="2233445566",
                EmailAddress ="Charlie@example.com",
                Hobbies="Futsal, Reading",
                DateOfBirth = new DateTime(2007, 10, 15),
                },

            new Student{
                FirstName ="Echo",
                LastName ="Fox",
                MobileNumber ="3344556677",
                EmailAddress ="Echo@example.com",
                Hobbies="Basketball, Swimming",
                DateOfBirth = new DateTime(2007, 08, 10),
                },

            new Student{
                FirstName ="Gulf",
                LastName ="Hotel",
                MobileNumber ="4455667788",
                EmailAddress ="Gulf@example.com",
                Hobbies="Handball, ESPORTS",
                DateOfBirth = new DateTime(2007, 06, 05),
                },

            new Student{
                FirstName ="India",
                LastName ="Jeddah",
                MobileNumber ="5566778899",
                EmailAddress ="India@example.com",
                Hobbies="Volleyball, Cycling",
                DateOfBirth = new DateTime(2007, 04, 01),
            }
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }

            List<Instructor> instructors = new List<Instructor>
            {
            new Instructor{
                FirstName ="Kilo",
                LastName ="Lima",
                MobileNumber ="6677889911",
                EmailAddress ="Kilo@example.com",
                },
            new Instructor{
                FirstName ="Mike",
                LastName ="Nancy",
                MobileNumber ="7788991122",
                EmailAddress ="Mike@example.com",
                },
            new Instructor{
                FirstName ="Oscar",
                LastName ="Paris",
                MobileNumber ="8899112233",
                EmailAddress ="Oscar@example.com",
                },
            new Instructor{
                FirstName ="Queen",
                LastName ="Romeo",
                MobileNumber ="9911223344",
                EmailAddress ="Kilo@example.com",
                },
            new Instructor{
                FirstName ="Sugar",
                LastName ="Tango",
                MobileNumber ="1223344556",
                EmailAddress ="Kilo@example.com",
                },
            };

            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }

            List<Classroom> classrooms = new List<Classroom>
            {
            new Classroom{
                Name = "United",
                Capacity = 5
                },
            new Classroom{
                Name = "Vienna",
                Capacity = 4
                },
            new Classroom{
                Name = "Washington",
                Capacity = 3
                }
            };

            foreach (Classroom c in classrooms)
            {
                context.Classrooms.Add(c);
            }

            List<Subject> subjects = new List<Subject>
            {
            new Subject{
                Name = "Xray",
                ScheduleDay = Subject.ScheduleDays.Sun,
                },
            new Subject{
                Name = "Yankee",
                ScheduleDay = Subject.ScheduleDays.Tue,
                },
            new Subject{
                Name = "Zulu",
                ScheduleDay = Subject.ScheduleDays.Thu,
                }
            };

            foreach (Subject subj in subjects)
            {
                context.Subjects.Add(subj);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}