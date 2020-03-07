using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentId = "Peter Parker",
                EmailAddress = "spiderman@avengers.gov"
            },
            new Student {
                Id = 2,
                StudentId = "Scott Lang",
                EmailAddress = "antman@avengers.gov"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                FirstName = "Tony",
                LastName = "Stark",
                Age = 48
            },
            new Instructor {
                FirstName = "Steve",
                LastName = "Rogers",
                Age = 93
            }
        };
    }
}