

namespace Cosmetics.Tests.Engine
{

    using Cosmetics.Engine;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class CommandTests
    {
        [Test] //Best practices for test methods
        public void Parse_WhenInputParamIsValid_ShouldReturnNewCommandInstance()
        {
            // Arrange.
            const string input = "AddToCategory ForMale Cool";

            // Act.
            var actualCommand = Command.Parse(input);

            // Assert.
            Assert.IsInstanceOf<Command>(actualCommand);
        }

        [Test] //Best test method
        public void Parse_WhenInputParamIsValid_ShouldCorrectlySetNameProperty()
        {
            // Arrange.
            const string input = "AddToCategory ForMale Cool";

            // Act.
            var actualCommand = Command.Parse(input);

            // Assert.
            var expectedNamePropertyValue = "AddToCategory";
            Assert.AreEqual(expectedNamePropertyValue, actualCommand.Name);
        }

        
        [Test]
        public void Parse_WhenInputParamIsValid_ShouldCorrectlySetParametersProperty()
        {
            // Arrange.
            const string input = "CreateToothpaste White+ Colgate 15.50 men fluor,bqla,golqma";

            // Act.
            var actualCommand = Command.Parse(input);

            // Assert.
            var expectedParametersValue = new List<string> { "White+", "Colgate", "15.50", "men", "fluor,bqla,golqma" };
            CollectionAssert.AreEqual(expectedParametersValue, actualCommand.Parameters);

        }

        [Test]
        public void Parse_WhenInputParamIsNull_ShouldThrowNullReferenceException()
        {
            // Arrange.
            string input = null;

            // Act & Assert.
            Assert.Throws<NullReferenceException>(() => Command.Parse(input));
        }

        [Test]
        public void Parse_WhenInputParamHasInvalidName_ShouldThrowArgumentNullExceptionWithCorrectMessage()
        {
            // Arrange.
            const string invalidInput = " ForMale Cool";

            // Act & Assert.
            Assert.That(() => Command.Parse(invalidInput), Throws.ArgumentNullException.With.Message.Contains("Name"));
        }

        [TestCase("AddToCategory ")]
        public void Parse_WhenInputParamHasInvalidParameters_ShouldThrowArgumentNullExceptionWithCorrectMessage(string invalidInput)
        {
            // Act & Assert.
            Assert.That(() => Command.Parse(invalidInput), Throws.ArgumentNullException.With.Message.Contains("List"));
        }
    }
}
