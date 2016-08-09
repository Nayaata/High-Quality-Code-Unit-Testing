namespace Cosmetics.Tests.Products
{
    using Cosmetics.Common;
    using Cosmetics.Products;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class ToothpasteTests
    {
        [Test]
        public void Print_WhenInvoked_ShouldReturnToothpasteDetailsInValidStringFormat()
        {
            // Arrange
            var toothpaste = new Toothpaste("example", "Pesho", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" });

            var expectedResult = new StringBuilder();
            expectedResult.AppendLine("- Pesho - example:");
            expectedResult.AppendLine("  * Price: $10");
            expectedResult.AppendLine("  * For gender: Unisex");
            expectedResult.Append("  * Ingredients: Zele, Chesun");

            // Act
            var actualResult = toothpaste.Print();

            // Assert
            Assert.AreEqual(expectedResult.ToString(), actualResult);
        }
    }
}