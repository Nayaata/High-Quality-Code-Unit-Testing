namespace CosmeticsTest
{
    using System;
    using System.IO;
    using System.Linq;
    using Cosmetics.Contracts;
    using Cosmetics.Engine;
    using Cosmetics.Products;
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class CosmeticsEngineTest
    {
        //MoQ examples
        [Test]
        public void Start_ShouldThrowArgumentNullExceptionWhenTheInputStringIsNotInTheCorrectFormat()
        {
            Console.SetIn(new StringReader("CreateToothpaste     "));

            var factory = new Mock<ICosmeticsFactory>();
            var shoppingCart = new Mock<IShoppingCart>();
            //factory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(new Category("ForMale"));

            var engine = new CosmeticsEngine(factory.Object, shoppingCart.Object);

            Assert.Throws<ArgumentNullException>(() => engine.Start());

            //engine.Start();

            //factory.Verify(x => x.CreateCategory(It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void Start_ShouldReadParseAndExecuteCreateCategoryCommand()
        {
            Console.SetIn(new StringReader("CreateCategory ForMale"));

            var factory = new Mock<ICosmeticsFactory>();
            var shoppingCart = new Mock<IShoppingCart>();

            var engine = new ExtendedCosmeticsEngine(factory.Object, shoppingCart.Object);
            engine.Start();

            Assert.IsTrue(engine.Categories.Any(x => x.Key == "ForMale"));
        }

        //Failed Test

        [Test]
        public void fsaasf()
        {
            Console.SetIn(new StringReader("AddToCategory ForMale Dasa"));

            var factory = new Mock<ICosmeticsFactory>();
            var shoppingCart = new Mock<IShoppingCart>();

            var name = "ForMale";

            var engine = new ExtendedCosmeticsEngine(factory.Object, shoppingCart.Object);
            engine.Start();

            engine.Categories.Add(name, new Category(name)); //??

        }
    }
}
