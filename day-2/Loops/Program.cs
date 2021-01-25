using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[]
            {
                "Course 1",
                "Course 2",
                "Course 3"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            // Or use this
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }

          
        }
    }
}
