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
                FirstName ="StdFN01",
                LastName ="StdLN01",
                MobileNumber ="01",
                EmailAddress ="std01@email.com",
                Hobbies ="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 12, 31),
                },

            new Student{
                FirstName ="StdFN02",
                LastName ="StdLN02",
                MobileNumber ="02",
                EmailAddress ="std02@email.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 12, 15),
                },

            new Student{
                FirstName ="StdFN03",
                LastName ="StdLN03",
                MobileNumber ="03",
                EmailAddress ="std03@email.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 12, 10),
                },

            new Student{
                FirstName ="StdFN04",
                LastName ="StdLN04",
                MobileNumber ="04",
                EmailAddress ="std04@email.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 12, 05),
                },

            new Student{
                FirstName ="StdFN05",
                LastName ="StdLN05",
                MobileNumber ="05",
                EmailAddress ="std05@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 11, 30),
            },

            new Student{
                FirstName ="StdFN06",
                LastName ="StdLN06",
                MobileNumber ="06",
                EmailAddress ="std06@example.com",
                Hobbies="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 11, 14),
            },

            new Student{
                FirstName ="StdFN07",
                LastName ="StdLN07",
                MobileNumber ="07",
                EmailAddress ="std07@example.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 11, 04),
            },

            new Student{
                FirstName ="StdFN08",
                LastName ="StdLN08",
                MobileNumber ="08",
                EmailAddress ="std08@example.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 10, 29),
            },

            new Student{
                FirstName ="StdFN09",
                LastName ="StdLN09",
                MobileNumber ="09",
                EmailAddress ="std09@example.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 10, 13),
            },

            new Student{
                FirstName ="StdFN10",
                LastName ="StdLN10",
                MobileNumber ="10",
                EmailAddress ="std10@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 10, 03),
            },

            new Student{
                FirstName ="StdFN11",
                LastName ="StdLN11",
                MobileNumber ="11",
                EmailAddress ="std11@email.com",
                Hobbies ="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 09, 28),
                },

            new Student{
                FirstName ="StdFN12",
                LastName ="StdLN12",
                MobileNumber ="12",
                EmailAddress ="std12@email.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 09, 13),
                },

            new Student{
                FirstName ="StdFN13",
                LastName ="StdLN13",
                MobileNumber ="13",
                EmailAddress ="std13@email.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 09, 02),
                },

            new Student{
                FirstName ="StdFN14",
                LastName ="StdLN14",
                MobileNumber ="14",
                EmailAddress ="std14@email.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 08, 27),
                },

            new Student{
                FirstName ="StdFN15",
                LastName ="StdLN15",
                MobileNumber ="15",
                EmailAddress ="std15@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 08, 12),
            },

            new Student{
                FirstName ="StdFN16",
                LastName ="StdLN16",
                MobileNumber ="16",
                EmailAddress ="std16@example.com",
                Hobbies="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 08, 01),
            },

            new Student{
                FirstName ="StdFN17",
                LastName ="StdLN17",
                MobileNumber ="17",
                EmailAddress ="std17@example.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 07, 26),
            },

            new Student{
                FirstName ="StdFN18",
                LastName ="StdLN18",
                MobileNumber ="18",
                EmailAddress ="std18@example.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 07, 11),
            },

            new Student{
                FirstName ="StdFN19",
                LastName ="StdLN19",
                MobileNumber ="19",
                EmailAddress ="std19@example.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 06, 30),
            },

            new Student{
                FirstName ="StdFN20",
                LastName ="StdLN20",
                MobileNumber ="20",
                EmailAddress ="std20@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 06, 25),
            },

            new Student{
                FirstName ="StdFN21",
                LastName ="StdLN21",
                MobileNumber ="21",
                EmailAddress ="std21@email.com",
                Hobbies ="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 06, 20),
                },

            new Student{
                FirstName ="StdFN22",
                LastName ="StdLN22",
                MobileNumber ="22",
                EmailAddress ="std22@email.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 06, 15),
                },

            new Student{
                FirstName ="StdFN23",
                LastName ="StdLN23",
                MobileNumber ="23",
                EmailAddress ="std23@email.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 06, 10),
                },

            new Student{
                FirstName ="StdFN24",
                LastName ="StdLN24",
                MobileNumber ="24",
                EmailAddress ="std24@email.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 06, 05),
                },

            new Student{
                FirstName ="StdFN25",
                LastName ="StdLN25",
                MobileNumber ="25",
                EmailAddress ="std25@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 05, 30),
            },

            new Student{
                FirstName ="StdFN26",
                LastName ="StdLN26",
                MobileNumber ="26",
                EmailAddress ="std26@example.com",
                Hobbies="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 05, 28),
            },

            new Student{
                FirstName ="StdFN27",
                LastName ="StdLN27",
                MobileNumber ="27",
                EmailAddress ="std27@example.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 05, 25),
            },

            new Student{
                FirstName ="StdFN28",
                LastName ="StdLN28",
                MobileNumber ="28",
                EmailAddress ="std28@example.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 05, 24),
            },

            new Student{
                FirstName ="StdFN29",
                LastName ="StdLN29",
                MobileNumber ="29",
                EmailAddress ="std29@example.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 05, 10),
            },

            new Student{
                FirstName ="StdFN30",
                LastName ="StdLN30",
                MobileNumber ="30",
                EmailAddress ="std30@example.com",
                Hobbies="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 05, 01),
            },

            new Student{
                FirstName ="StdFN31",
                LastName ="StdLN31",
                MobileNumber ="31",
                EmailAddress ="std31@email.com",
                Hobbies ="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 04, 26),
                },

            new Student{
                FirstName ="StdFN32",
                LastName ="StdLN32",
                MobileNumber ="32",
                EmailAddress ="std32@email.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 04, 15),
                },

            new Student{
                FirstName ="StdFN33",
                LastName ="StdLN33",
                MobileNumber ="33",
                EmailAddress ="std33@email.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 04, 10),
                },

            new Student{
                FirstName ="StdFN34",
                LastName ="StdLN34",
                MobileNumber ="34",
                EmailAddress ="std34@email.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 04, 05),
                },

            new Student{
                FirstName ="StdFN35",
                LastName ="StdLN35",
                MobileNumber ="35",
                EmailAddress ="std35@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 03, 30),
            },

            new Student{
                FirstName ="StdFN36",
                LastName ="StdLN36",
                MobileNumber ="36",
                EmailAddress ="std36@example.com",
                Hobbies="HOB01, HOB02",
                DateOfBirth = new DateTime(2007, 03, 20),
            },

            new Student{
                FirstName ="StdFN37",
                LastName ="StdLN37",
                MobileNumber ="37",
                EmailAddress ="std37@example.com",
                Hobbies="HOB03, HOB04",
                DateOfBirth = new DateTime(2007, 03, 10),
            },

            new Student{
                FirstName ="StdFN38",
                LastName ="StdLN38",
                MobileNumber ="38",
                EmailAddress ="std38@example.com",
                Hobbies="HOB05, HOB06",
                DateOfBirth = new DateTime(2007, 02, 27),
            },

            new Student{
                FirstName ="StdFN39",
                LastName ="StdLN39",
                MobileNumber ="39",
                EmailAddress ="std39@example.com",
                Hobbies="HOB07, HOB08",
                DateOfBirth = new DateTime(2007, 02, 12),
            },

            new Student{
                FirstName ="StdFN40",
                LastName ="StdLN40",
                MobileNumber ="40",
                EmailAddress ="std40@example.com",
                Hobbies="HOB09, HOB10",
                DateOfBirth = new DateTime(2007, 02, 07),
            },
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }

            List<Instructor> instructors = new List<Instructor>
            {
            new Instructor{
                FirstName ="InstFN001",
                LastName ="InstLN001",
                MobileNumber ="001",
                EmailAddress ="inst001@email.com",
                },

            new Instructor{
                FirstName ="InstFN002",
                LastName ="InstLN002",
                MobileNumber ="002",
                EmailAddress ="inst002@email.com",
                },

            new Instructor{
                FirstName ="InstFN003",
                LastName ="InstLN003",
                MobileNumber ="003",
                EmailAddress ="inst003@email.com",
                },

            new Instructor{
                FirstName ="InstFN004",
                LastName ="InstLN004",
                MobileNumber ="004",
                EmailAddress ="inst004@email.com",
                },

            new Instructor{
                FirstName ="InstFN005",
                LastName ="InstLN005",
                MobileNumber ="005",
                EmailAddress ="inst005@email.com",
                },

            new Instructor{
                FirstName ="InstFN006",
                LastName ="InstLN006",
                MobileNumber ="006",
                EmailAddress ="inst006@email.com",
                },

            new Instructor{
                FirstName ="InstFN007",
                LastName ="InstLN007",
                MobileNumber ="007",
                EmailAddress ="inst007@email.com",
                },

            new Instructor{
                FirstName ="InstFN008",
                LastName ="InstLN008",
                MobileNumber ="008",
                EmailAddress ="inst008@email.com",
                },

            new Instructor{
                FirstName ="InstFN009",
                LastName ="InstLN009",
                MobileNumber ="009",
                EmailAddress ="inst009@email.com",
                },

            new Instructor{
                FirstName ="InstFN010",
                LastName ="InstLN010",
                MobileNumber ="010",
                EmailAddress ="inst010@email.com",
                },
            };

            foreach (Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }

            List<Classroom> classrooms = new List<Classroom>
            {
            new Classroom{
                Name = "ClassroomName01",
                Capacity = 15
                },
            new Classroom{
                Name = "ClassroomName02",
                Capacity = 15
                },
            new Classroom{
                Name = "ClassroonName03",
                Capacity = 10
                }
            };

            foreach (Classroom c in classrooms)
            {
                context.Classrooms.Add(c);
            }

            List<Subject> subjects = new List<Subject>
            {
            new Subject{
                Name = "SubjectName01",
                ScheduleDay = Subject.ScheduleDays.Sun,
                },
            new Subject{
                Name = "SubjectName02",
                ScheduleDay = Subject.ScheduleDays.Mon,
                },
            new Subject{
                Name = "SubjectName03",
                ScheduleDay = Subject.ScheduleDays.Tue,
                },
            new Subject{
                Name = "SubjectName04",
                ScheduleDay = Subject.ScheduleDays.Wed,
                },
            new Subject{
                Name = "SubjectName05",
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