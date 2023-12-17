using Projects;
namespace Test_Programa_Descomptes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrintHeader()
        {
            // Arrange
            StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            MyProject.PrintHeader();

            // Assert
            string expected = "*******************************************\r\n" +
                              "*******************************************\r\n" +
                              "*********** Control clients ***************\r\n" +
                              "*******************************************\r\n" +
                              "*******************************************\r\n";

            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void TestPrintCompteNotFree()
        {
            // Arrange
            int age = 18;
            string name = "Pol";
            StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            MyProject.PrintCompte(age, name);

            // Assert
            string expected = "nom: Pol\r\n" +
                                    "edat: 18\r\n" +
                                    "El client no té entrada gratis.\r\n";

            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void TestPrintCompteFree()
        {
            // Arrange
            int age = 70;
            string name = "Jose Luis";
            StringWriter sw = new();
            Console.SetOut(sw);

            // Act
            MyProject.PrintCompte(age, name);

            // Assert
            string expected = "nom: Jose Luis\r\n" +
                                    "edat: 70\r\n" +
                                    "El client té entrada gratis.\r\n";

            Assert.AreEqual(expected, sw.ToString());
        }

        [TestMethod]
        public void TestEntradaGratisFalse()
        {
            // Arrange
            int age = 18;

            // Act
            bool result = MyProject.EntradaGratis(age);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestEntradaGratisTrue()
        {
            // Arrange
            int age = 70;

            // Act
            bool result = MyProject.EntradaGratis(age);

            // Assert
            Assert.IsTrue(result);
        }
    }
}