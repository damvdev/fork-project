using Projects;
namespace ForkTest
{
    [TestClass]
    public class VoidTests
    {
        [TestMethod]
        public void PrintCompteJubilat()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            MyProject.PrintCompte(65,"Laura");

            string expected = "El client té entrada gratis.";
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
        [TestMethod]
        public void PrintCompteNoJubilat()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            MyProject.PrintCompte(15, "Laura");

            string expected = "El client no té entrada gratis.";
            Assert.AreEqual(expected, sw.ToString().Trim());
        }
        [TestMethod]
        public void JubilatTrue()
        {
            int age = 70;
            bool result = MyProject.Jubilat(age);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void JubilatFalse()
        {
            int age = 20;
            bool result = MyProject.Jubilat(age);
            Assert.IsFalse(result);
        }
    }
}