using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            var customer = new Customer {FirstName = "Bilbo", LastName = "Baggins"};
            
            const string expected = "Baggins, Bilbo";
            
            //-- Act
            var actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var customer = new Customer { LastName = "Baggins" };

            const string expected = "Baggins";

            //-- Act
            var actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            var customer = new Customer { FirstName = "Bilbo" };

            const string expected = "Bilbo";

            //-- Act
            var actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            // ReSharper disable once ObjectCreationAsStatement
            new Customer {FirstName = "Bilbo"};
            Customer.InstanceCount += 1;
            new Customer { FirstName = "Frodo" };
            Customer.InstanceCount += 1;
            new Customer { FirstName = "Rosie" };
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer { LastName = "Baggins", EmailAddress = "fbaggins@hobbiton.me"};

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer { EmailAddress = "fbaggins@hobbiton.me" };

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(false, actual);
        }
    }
}
