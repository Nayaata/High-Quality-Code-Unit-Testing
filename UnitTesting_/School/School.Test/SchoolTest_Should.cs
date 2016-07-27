namespace School.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTest_Should
    {
        [TestMethod]
        public void ContainsCourses_ThatAreNotNullOrEmpty()
        {
            var school = new School();

            Assert.IsNotNull(school.Courses);
        }
    }
}
