using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
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