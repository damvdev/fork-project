using Projects;
namespace ProjectsTest
{
    [TestClass]
    public class ProjectsTest
    {
        [TestMethod]
        public void PrintHeader()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            Projects.MyProject.PrintHeader();


            string expected = "*******************************************" +
                              "\n*******************************************" +
                              "\n*********** Control clients ***************" +
                              "\n*******************************************" +
                              "\n*******************************************";

            Assert.AreEqual(expected, sw.ToString().Trim());
        }

        [TestMethod] public void TestPensioner_65_True() 
        {
            //Arrange
            int age = 65;

            //Act
            bool result=Projects.MyProject.Pensioner(age);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPensioner_MinorThan65_False()
        {
            //Arrange
            int age = 60;

            //Act
            bool result = Projects.MyProject.Pensioner(age);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestPensioner_MajorThan65_True()
        {
            //Arrange
            int age = 68;

            //Act
            bool result = Projects.MyProject.Pensioner(age);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestPensioner_0_False()
        {
            //Arrange
            int age = 0;

            //Act
            bool result = Projects.MyProject.Pensioner(age);

            //Assert
            Assert.IsFalse(result);
        }
        
        [TestMethod]
        public void TestPrintTicket()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            Projects.MyProject.PrintTicket(65,"Antonio");

            string expected = "*******************************************" +
                              "\n*******************************************" +
                              "\n*********** Control clients ***************" +
                              "\n*******************************************" +
                              "\n*******************************************" +
                "\nnom:" +
                "\nedat:" +
                "\nEl client te entrada gratis.";
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
    }
}