
namespace CosmeticsTest
{
    using System;
    using Cosmetics.Engine;
    using NUnit.Framework;

    [TestFixture]
    public class CommandTest
    {
        [TestCase("Test Command.Parse")]
        public void Parse_ShouldReturnNewCommandWhenTheInputStringIsInValidFormat(string input)
        {
            var newCommand = Command.Parse(input);

            Assert.IsInstanceOf<Command>(newCommand);
        }

        [TestCase("CreateShampoo Cool Nivea 0.50 men")]
        public void Parse_ShouldSetCorrectValuesToTheNewCommandObjectsNameWhenTheInputStringIsInValidFormat(string input)
        {
            var newCommand = Command.Parse(input);

            Assert.AreEqual(input, newCommand.Name);
        }

        //Failed Test
        [TestCase("CreateToothpaste White+ Colgate 15.50 men fluor, bqla, golqma")] //or other
        public void Parse_ShouldSetCorrectValuesToTheNewCommandObjectsParametersWhenTheInputStringIsInValidFormat(string input)
        {
            var newCommand = Command.Parse(input);

            Assert.AreEqual("White+ Colgate 15.50 men fluor, bqla, golqma", string.Join(" ", newCommand.Parameters));
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullExceptionStringNameWhenRepresentCommandName()
        {
            try
            {
                var newCommand = Command.Parse("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.IsTrue(ex.Message.Contains("Name"));
            }
        }

        [Test]
        public void Parse_ShouldThrowArgumentNullExceptionWithStringListWhenRepresentCommandParameters()
        {
            try
            {
                var newCommand = Command.Parse("CreateShampoo");
            }
            catch (ArgumentNullException ex)
            {
                Assert.IsTrue(ex.Message.Contains("List"));
            }
        }


    }

}
