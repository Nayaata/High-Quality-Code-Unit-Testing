using System;
using Cosmetics.Common;
using NUnit.Framework;

namespace CosmeticsTest
{
    [TestFixture]
    public class ValidatorTest
    {
        [Test]
        public void CheckIfNull_ThrowNullReferenceExceptionWhenObjIsNull()
        {
            object obj = null;

            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(obj));
        }

        [TestCase("")]
        [TestCase("testIt")]
        [TestCase(1)]
        public void CheckIfNull_ShouldNotThrowAnyExceptionWhenObjIsNotNull(object obj)
        {
            Assert.DoesNotThrow(() => Validator.CheckIfNull(obj));
        }

        [TestCase("")]
        [TestCase(null)]
        public void CheckIfStringIsNullOrEmpty_ShouldThrowNullReferenceExceptionWhenParameterTextIsNull(string text)
        {
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [TestCase("Test")]
        [TestCase(" ")]
        public void CheckIfStringIsNullOrEmpty_ShouldNotThrowAnyExceptionWhenParameterTextIsNull(string text)
        {
            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [TestCase("Hi")]
        [TestCase("Hello Mark Morison")]

        public void CheckIfStringLengthIsValid_ShouldThrowIndexOutOfRangeExceptionWhenTheLengthIsLowerThanMinimumOrGreaterThantTheMaximum(string text)
        {
            int min = 3;
            int max = 10;

            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(text, max, min));
        }

        [Test]
        public void CheckIfStringLengthIsValid_ShouldNotThrowAnyExceptionWhenTheLengthOfTheParameterTextIsInTheAllowedBoundaries()
        {
            string text = "Hola!";
            int min = 3;
            int max = 10;

            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(text, max, min));
        }
    }
}
