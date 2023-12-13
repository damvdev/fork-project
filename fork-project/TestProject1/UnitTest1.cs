using Projects;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Jubilat_True()
        {
            // Arrange
            int age = 66;

            // Act
            bool result = MyProject.EsJubilat(age);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Jubilat_False()
        {
            // Arrange
            int age = 45;

            // Act
            bool result = MyProject.EsJubilat(age);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PrintCompteVoid_Jubilat()
        {
            // Arrange
            int age = 70;
            string name = "Bob";
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            MyProject.PrintCompte(age, name);
            string result = writer.ToString().Trim();
            string nameString = "nom: " + name;
            string edatString = "edat: " + age;

            // Assert
            Assert.IsTrue(result.Contains(nameString));
            Assert.IsTrue(result.Contains(edatString));
            Assert.IsTrue(result.Contains("El client té entrada gratis."));
        }
    }
}