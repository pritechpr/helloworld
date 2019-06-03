using NUnit.Framework;
using iTrellis.HelloWorld.WebAPI.Controllers;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //placeholder
        }

        [Test]
        public void HelloWorldTest()
        {
            //arrange
            var hwController = new HelloWorldController();

            //act
            var result = hwController.HelloWorld();

            //assert
            Assert.IsTrue(result.Value.Equals("Hello, world."));
        }
    }
}
