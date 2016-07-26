
namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Course
    {
        public Course()
        {
            this.Students = new List<Student>();
        }

        public IList<Student> Students { get; set; }


    }
}
