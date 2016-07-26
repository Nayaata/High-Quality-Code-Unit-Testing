

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string name;
        private int uid;

        public Student(string name, int uid)
        {
            this.Name = name;
            this.Uid = uid;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            private set
            {
                if (this.name == null || this.name.Length == 0)
                {
                    throw new ArgumentNullException("Name can not be empty!");
                }

                this.name = value;
            }
        }

        public int Uid 
        { 
            get
            {
                return this.uid;
            }
            private set
            {
                if (this.uid < 10000 || this.uid > 99999)
                {
                    throw new ArgumentOutOfRangeException("The unique number is between 10000 and 99999!");
                }
            }
        }
    }
}
