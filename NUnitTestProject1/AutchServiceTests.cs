using NUnit.Framework;

namespace App.Tests
{
    public class AutchServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Сидоров")]
        [TestCase("Петров")]
        public void AutchService_Login_Test_IsTrue(string lastName)
        {
            //arrange

            

            var service = new AutchService();

            //act

            var result = service.Login(lastName);

            //assert

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("Ser")]
        [TestCase("")]
        public void AutchService_Login_Test_IsFalse(string  lastName)
        {
            //arrange

            

            var service = new AutchService();

            //act

            var result = service.Login(lastName);

            //assert

            Assert.IsFalse(result);
        }
    }
}