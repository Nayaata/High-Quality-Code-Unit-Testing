
namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private IList<Student> students;
        public Course()
        {
            this.Students = new List<Student>();
        }

        public IList<Student> Students
        {
            get
            {
                return this.Students;
            }
            set
            {
                if (this.Students.Count >= 30)
                {
                    throw new ArgumentOutOfRangeException("Students in a course should be less than 30!");
                }

                this.Students = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

    }
}
