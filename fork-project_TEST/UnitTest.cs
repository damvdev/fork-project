using Microsoft.VisualStudio.TestPlatform.Utilities;
using Projects;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {

        // Jubilat Function

        [TestMethod]
        public void Jubilat_ReturnTrue_EqualThan65()
        {
            // Arrange
            int age = 65;

            // Act
            bool result = MyProject.Jubilat(age);

            // Assert
            Assert.IsTrue(result);
        }
        public void Jubilat_ReturnTrue_BiggerThan65()
        {
            // Arrange
            int age = 70;

            // Act
            bool result = MyProject.Jubilat(age);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Jubilat_ReturnFalse_LowerThan65()
        {
            // Arrange
            int age = 20;

            // Act
            bool result = MyProject.Jubilat(age);

            // Assert
            Assert.IsFalse(result);
        }

        // EntradaGratis Function

        [TestMethod]
        public void EntradaGratis_ReturnTrue_ForRetiredCustomer()
        {
            // Arrange
            int RetiredAge = 70;

            // Act
            bool result = MyProject.EntradaGratis(RetiredAge);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EntradaGratis_ReturnFalse_ForNotRetiredCustomer()
        {
            // Arrange
            int NotRetiredAge = 30;

            // Act
            bool result = MyProject.EntradaGratis(NotRetiredAge);

            // Assert
            Assert.IsFalse(result);
        }

        // PrintHeader Function with Void

        [TestMethod]
        public void PrintHeader_PrintCorrectlyTheHeader()
        {
            // Arrange
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            // Act
            MyProject.PrintHeader();

            // Assert
            string result = "*******************************************" +
                          "\n*******************************************" +
                          "\n*********** Control clients ***************" +
                          "\n*******************************************" +
                          "\n*******************************************\r\n";

            Assert.AreEqual(result, output.ToString());
        }

        // PrintCompte Function with Void

        [TestMethod]
        public void PrintCompte_PrintCorrectlyTheCustomerAccount()
        {
            // Arrange
            int age = 70;
            string name = "Hola";
            StringWriter output = new StringWriter();
            Console.SetOut(output);

            // Act
            MyProject.PrintCompte(age, name);

            // Assert
            string result =
                ("*******************************************" +
                "\n*******************************************" +
                "\n*********** Control clients ***************" +
                "\n*******************************************" +
                "\n*******************************************\n" +
                $"\n Nom: {name} \nEdat: {age} \nEl client t� entrada gratis.");

            Assert.AreEqual(result, output.ToString());
        }

    }
}
