using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Name = "C#";
            course1.Instructor = "John Doe";
            course1.ViewRate = 75;
            
            Course course2 = new Course();
            course2.Name = "Java";
            course2.Instructor = "Martin Kuyt";
            course2.ViewRate = 85;

            Course[] courses = new Course[] { course1, course2 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
            }


        }
    }

    class Course
    {
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int ViewRate { get; set; }

    }
}
