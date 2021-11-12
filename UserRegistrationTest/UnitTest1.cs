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

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string expected = "Valid";

            //Act
            UserRegistration test = new UserRegistration();
            string actual = test.ValidEmail("abc.vicky@bl.co.in");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string expected = "Valid";

            //Act
            UserRegistration test = new UserRegistration();
            string actual = test.MobileNumber("91 1234567890");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string expected = "Valid";

            //Act
            UserRegistration test = new UserRegistration();
            //string actual = test.ValidPasword("ADEdvfed47@af&");
            string actual = test.ValidPasword("VIGmuthu05@mv");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataTestMethod] //for testing multiple data

        [DataRow("1.abc@yahoo.com")]
        [DataRow("2.abc-100@yahoo.com")]
        [DataRow("3.abc.100@yahoo.com")]
        [DataRow("2.abc111@abc.com")]
        [DataRow("4.abc-100@abc.net")]
        [DataRow("5.abc.100@abc.com.au")]
        [DataRow("6.abc@1.com")]
        [DataRow("7.abc@gmail.com.com")]
        [DataRow("8.abc+100@gmail.com")]

        public void TestMethod6(string mail)
        {
            //Arrange
            string expected = "Valid";

            //Act
            UserRegistration test = new UserRegistration();
            string actual = test.AllValidEmail(mail);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
