namespace School.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTest_Should
    {
        [TestMethod]
        public void ContainsStudentsCollection_ThatCountIsLesThan()
        {
            var course = new Course();

            Assert.IsTrue(course.Students.Count <= 30);
        }

        [TestMethod]
        public void ContainsStudentsCollection_ThatCanAddStudents()
        {
            var course = new Course();
            var student = new Student("Jhon", 38118381);

            course.AddStudent(student);

            Assert.AreEqual(course.Students.Count, 1);
        }

        [TestMethod]
        public void ContainsStudentsCollection_ThatCanRemoveStudents()
        {
            var course = new Course();
            var student = new Student("Jane", 38111805);

            course.RemoveStudent(student);

            Assert.AreNotEqual(course.Students.Count, 0);
        }
    }
}
