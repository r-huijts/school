using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            Course course = new Course();
            course.Name = "Software Engineering";
            course.Room = "OIL1.60";

            while (keepRunning)
            {
                Console.WriteLine("What is the first name?");
                string firstName = Console.ReadLine();
                Console.WriteLine("What is the last name?");
                string LastName = Console.ReadLine();

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = LastName;

                course.AddStudent(student);

                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine($"For course with name {course.Name} in room {course.Room} the following students have signed up:");
                foreach(Student studentInList in course.Students)
                {
                    Console.WriteLine(studentInList.FirstName + " " + studentInList.LastName);
                }
                Console.WriteLine("======================================");
                Console.WriteLine();
            }
    // ZELF VERDER ONDERZOEKEN:
    // Properties
    // Encapsulation
    // Constructor

        }
    }
}
