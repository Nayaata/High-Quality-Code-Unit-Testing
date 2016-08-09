
namespace Cosmetics.Tests.Common
{
    using Cosmetics.Common;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void CheckIfNull_WhenObjParamIsNull_ShouldThrowNullReferenceException()
        {
            //Arrange
            object testObject = null;

            //Act & Assert
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(testObject));

        }

        [Test]
        public void CheckIfNull_WhenObjParamIsNotNull_ShouldNotThrowAnyException()
        {
            object testObject = new object();
            Assert.DoesNotThrow(() => Validator.CheckIfNull(testObject));
        }

        //[TestCase()]
        /* or
        [TestCase("")]
        [TestCase(18)]
        [TestCase("Test")]
        public void CheckIfNull_WhenObjParamIsNotNull_ShouldNotThrowAnyException(object testObject)
        {
            Assert.DoesNotThrow(() => Validator.CheckIfNull(testObject));
        }
        */

        [TestCase(null)]
        [TestCase("")]
        public void CheckIfStringIsNullOrEmpty_WhenParameterTextIsInvalid_ShouldThrowNullReferenceException(string textParam) //when the parameter "text" is null or empty
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(textParam));
        }

        [TestCase("Test")]
        [TestCase("ExampleToTest")]
        [TestCase("ExampleStr")]
        public void CheckIfStringIsNullOrEmpty_WhenParameterTextIsValid_ShouldNotThrowAnyException(string textParam) //when the parameter "text" is null or empty
        {
            // Arrange
            //var exampleString = "20CharactersLongText";

            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(textParam));
        }

        [TestCase(25, 25)]
        [TestCase(15, 25)]
        [TestCase(15, 5)]
        [TestCase(15, 0)]
        public void CheckIfStringLengthIsValid_WhenTextParamHasInvalidLenght_ShouldThrowIndexOutOfRangeException(int max, int min)
        {
            // Arrange.
            var exampleString = "20CharactersLongText";

            // Act & Assert.
            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(exampleString, max, min));
        }

        [TestCase(25, 20)]
        [TestCase(25, 15)]
        [TestCase(20, 20)]
        [TestCase(20, 0)]
        public void CheckIfStringLengthIsValid_WhenTextParamHasValidLenght_ShouldNotThrowAnyException(int max, int min)
        {
            var exampleString = "20CharactersLongText";

            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(exampleString, max, min));
        }
    }

}
