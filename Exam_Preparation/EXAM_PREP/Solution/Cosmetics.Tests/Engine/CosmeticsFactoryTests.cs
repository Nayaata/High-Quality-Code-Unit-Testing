namespace Cosmetics.Tests.Engine
{
    using Contracts;
    using Cosmetics.Common;
    using Cosmetics.Engine;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //"20CharactersLongText"
    // "example", 10.0M, GenderType.Unisex, 100, UsageType.Medical
    [TestFixture]
    public class CosmeticsFactoryTests
    {
        [TestCase(null)]
        [TestCase("")]

        public void CreateShampoo_WhenNameParamIsNullOrEmpty_ShouldThrowNullReferenceException(string nameParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateShampoo(nameParam, "example", 10.0M, GenderType.Men, 100, UsageType.EveryDay));
        }

        [TestCase("as")]
        [TestCase("20CharactersLongText")]
        public void CreateShampoo_WhenNameParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string nameParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateShampoo(nameParam, "example", 10.0M, GenderType.Unisex, 100, UsageType.Medical));
        }

        [TestCase(null)]
        [TestCase("")]
        public void CreateShampoo_WhenBrandParamIsNullOrEmpty_ShouldThrowNullReferenceException(string brandParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateShampoo("example", brandParam, 10.0M, GenderType.Unisex, 100, UsageType.Medical));
        }

        [TestCase("!")]
        [TestCase("20CharactersLongText")]
        public void CreateShampoo_WhenBrandParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string brandParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateShampoo("example", brandParam, 10.0M, GenderType.Unisex, 100, UsageType.Medical));
        }

        [Test]
        public void CreateShampoo_WhenAllParamsAreValid_ShouldReturnInstanceOfShampoo()
        {
            // Assert.
            var cosmeticFactory = new CosmeticsFactory();

            // Act.
            var actualFactory = cosmeticFactory.CreateShampoo("nameEx", "brandEx", 10.0M, GenderType.Unisex, 100, UsageType.Medical);

            // Assert.
            Assert.IsInstanceOf<IShampoo>(actualFactory);
        }

        [TestCase(null)]
        [TestCase("")]
        public void CreateCategory_WhenNameParamIsNullOrEmpty_ShouldThrowNullReferenceException(string nameParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateCategory(nameParam));
        }

        [TestCase("1")]
        [TestCase("20CharactersLongText")]
        public void CreateCategory_WhenNameParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string nameParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateCategory(nameParam));
        }

        [Test]
        public void CreateCategory_WhenNameParamIsValid_ShouldReturnInstanceOfCategory()
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act.
            var actualFactory = cosmeticFactory.CreateCategory("Pesho");

            // Assert.
            Assert.IsInstanceOf<ICategory>(actualFactory);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpaste_WhenNameParamIsNullOrEmpty_ShouldThrowNullReferenceException(string nameParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateToothpaste(nameParam, "example", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [TestCase("is")]
        [TestCase("20CharactersLongText")]
        public void CreateToothpaste_WhenNameParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string nameParam)
        {
            // Arrange.
            var cosmeticFactory = new CosmeticsFactory();

            // Act & Assert.
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste(nameParam, "example", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [TestCase("")]
        [TestCase(null)]
        public void CreateToothpaste_WhenBrandParamIsNullOrEmpty_ShouldThrowNullReferenceException(string brandParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<NullReferenceException>(() => cosmeticFactory.CreateToothpaste("Gosho", brandParam, 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [TestCase("a")]
        [TestCase("20CharactersLongText")]
        public void CreateToothpaste_WhenBrandParamLenghtIsOutOfRange_ShouldThrowIndexOutOfRangeException(string brandParam)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste("Gosho", brandParam, 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" }));
        }

        [Test]
        public void CreateToothpaste_WhenNameParamIsValid_ShouldReturnInstanceOfToothpaste()
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act
            var actualFactory = cosmeticFactory.CreateToothpaste("Gosho", "example", 10M, GenderType.Unisex, new List<string>() { "Zele", "Chesun" });

            // Assert
            Assert.IsInstanceOf<IToothpaste>(actualFactory);
        }

        [TestCase("Luk", "Chesun")]
        [TestCase("ZelenchukovaSupa", "Chesun")]
        [TestCase("Chesun", "Luk")]
        [TestCase("Chesun", "ZelenchukovaSupa")]
        public void CreateToothpaste_WhenIngredientsHaveInvalidLenght_ShouldThrowIndexOutOfRangeException(params string[] ingredients)
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => cosmeticFactory.CreateToothpaste("Gosho", "example", 10M, GenderType.Unisex, ingredients.ToList()));
        }

        [Test]
        public void Test()
        {
            // Arrange
            var cosmeticFactory = new CosmeticsFactory();

            // Act.
            var actualFactory = cosmeticFactory.CreateShoppingCart();

            // Assert
            Assert.IsInstanceOf<IShoppingCart>(actualFactory);
        }
    }
}
