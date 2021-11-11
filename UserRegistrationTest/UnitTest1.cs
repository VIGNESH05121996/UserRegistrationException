using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationException;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expected = "Valid";

            //Act
            UserRegistration test = new UserRegistration();
            string actual = test.FirstName("Vignesh");

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string expected = "Valid";

            //Act
            UserRegistration test = new UserRegistration();
            string actual = test.LastName("Marimuthu");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
