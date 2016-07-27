

namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int uniqueNumber = 10000;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = ++uniqueNumber;
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

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }
            private set
            {
                if (this.uniqueNumber < 10000 || this.uniqueNumber > 99999)
                {
                    throw new ArgumentOutOfRangeException("The unique number is between 10000 and 99999!");
                }
            }
        }
    }
}
