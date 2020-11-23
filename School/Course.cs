using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        public string Name;
        public string Room;

        public List<Student> Students = new List<Student>();


        public Course()
        {

        }

        public void AddStudent(Student student)
        {
            Students.Add(student)
        }
    }
}
