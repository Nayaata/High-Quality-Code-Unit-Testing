namespace School
{
    using System.Collections.Generic;

    public class School
    {
        public School()
        {
            this.Courses = new List<Course>();
        }

        public IList<Course> Courses { get; private set; }

    }
}
