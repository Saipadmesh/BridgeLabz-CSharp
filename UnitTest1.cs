using UserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        // UC10

        [TestMethod]
        [DataRow("Sai")]
        [DataRow("Padmesh")]
        public void RightFirstNameIsEntered(string val)
        {
            // Arrange
            User user= new User();

            // Act
            user.RegisterFirstName(val);

            // Assert
            Assert.AreEqual(val, user.FirstName);
        }

        [TestMethod]
        [DataRow("ab")]
        [ExpectedException(typeof(UserException))]
        public void WrongFirstNameIsNotEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterFirstName(val);
            Console.WriteLine(user.FirstName);
            // Assert
            Assert.IsNull(user.FirstName);
        }

        [TestMethod]
        [DataRow("Sai")]
        public void RightLastNameIsEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterLastName(val);

            // Assert
            Assert.AreEqual(val, user.LastName);
        }

        [TestMethod]
        [DataRow("ab")]
        [ExpectedException(typeof(UserException))]
        public void WrongLastNameIsNotEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterLastName(val);

            // Assert
            Assert.IsNull(user.LastName);
        }

        [TestMethod]
        [DataRow("91 8072669384")]
        public void RightPhoneNoIsEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterPhoneNo(val);

            // Assert
            Assert.AreEqual(val, user.PhoneNo);
        }

        [TestMethod]
        [DataRow("12345678")]
        [ExpectedException(typeof(UserException))]
        public void WrongPhoneNoIsNotEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterPhoneNo(val);

            // Assert
            Assert.IsNull(user.PhoneNo);
        }

        [TestMethod]
        [DataRow("Saipadmesh@gmail.com")]
        public void RightEmailIsEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterEmail(val);

            // Assert
            Assert.AreEqual(val, user.Email);
        }

        [TestMethod]
        [DataRow("ab123_5")]
        [ExpectedException(typeof(UserException))]
        public void WrongEmaileIsNotEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterLastName(val);

            // Assert
            Assert.IsNull(user.LastName);
        }

        [TestMethod]
        [DataRow("#sAiPad12")]
        public void RightPasswordIsEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterPassword(val);

            // Assert
            Assert.AreEqual(val, user.Password);
        }

        [TestMethod]
        [DataRow("som1")]
        [ExpectedException(typeof(UserException))]
        public void WrongPasswordIsNotEntered(string val)
        {
            // Arrange
            User user = new User();

            // Act
            user.RegisterPassword(val);

            // Assert
            Assert.IsNull(user.Password);
        }
    }
}