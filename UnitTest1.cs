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
    }
}