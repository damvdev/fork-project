using Projects;

namespace TestProjectTicketInfo
{
    [TestClass]
    public class UnitTestPrintCheck
    {
        [TestMethod]
        public void PrintCheckPositiveAgeNameNotNull()
        {
            //Arrange
            const int age = 19;
            const string name = "Sandro";
            const string expected = "El client no té entrada gratis.";



            //Act
            string result = TicketInfo.PrintCheck(age, name);


            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void PrintCheckNegativeAgeNameNotNull()
        {
            //Arrange
            const int age = -10;
            const string name = "Sandro";
            const string expected = "El client no té entrada gratis.";



            //Act
            string result = TicketInfo.PrintCheck(age, name);


            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void PrintCheckNegativeAgeNameEmpty()
        {
            //Arrange
            const int age = -10;
            const string name = "";
            const string expected = "El client no té entrada gratis.";



            //Act
            string result = TicketInfo.PrintCheck(age, name);


            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void PrintCheckAgeEqualSixtySixNameEmpty()
        {
            //Arrange
            const int age = 66;
            const string name = "";
            const string expected = "El client té entrada gratis.";



            //Act
            string result = TicketInfo.PrintCheck(age, name);


            //Assert
            Assert.AreEqual(expected, result);

        }
    }

    [TestClass]
    public class UnitTestFreeTicket
    {
        [TestMethod]
        public void FreeTicketPositiveAge()
        {
            //Arrange
            const int age = 19;
            const bool expected = false;

            //Act
            bool result = TicketInfo.FreeTicket(age);


            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void FreeTicketNegativeAge()
        {
            //Arrange
            const int age = -10;
            const bool expected = false;

            //Act
            bool result = TicketInfo.FreeTicket(age);


            //Assert

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void FreeTicketAgeGreaterThan65()
        {
            //Arrange
            const int age = 70;
            const bool expected = true;

            //Act
            bool result = TicketInfo.FreeTicket(age);


            //Assert
            Assert.AreEqual(expected, result);

        }
    }

    [TestClass]
    public class UnitTestJubilee
    {
        [TestMethod]
        public void JubileePositiveAge()
        {
            //Arrange
            const int age = 19;
            const bool expected = false;

            //Act
            bool result = TicketInfo.Jubilee(age);


            //Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void JubileeNegativeAge()
        {
            //Arrange
            const int age = -10;
            const bool expected = false;

            //Act
            bool result = TicketInfo.Jubilee(age);


            //Assert

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void JubileeAgeGreaterThan65()
        {
            //Arrange
            const int age = 70;
            const bool expected = true;

            //Act
            bool result = TicketInfo.Jubilee(age);


            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}