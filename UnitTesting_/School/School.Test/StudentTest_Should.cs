namespace School.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTest_Should
    {
        [TestMethod]
        public void HaveName_ThatIsNotNull()
        {
            var student = new Student("Alex", 18092919);

            Assert.IsFalse(string.IsNullOrEmpty(student.Name));
        }

        [TestMethod]
        public void HaveName_ThatIsNotEmpty()
        {
            var student = new Student("An", 19092929);

            Assert.IsTrue(student.Name.Length >= 0);
        }

        [TestMethod]
        public void ContainsUniqueNumber_ThatIsBetween()
        {
            var student = new Student("Boris", 22092929);

            Assert.IsTrue(student.UniqueNumber >= 10000 && student.UniqueNumber < 99999);
        }
    }
}
