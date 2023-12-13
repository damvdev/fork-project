using Projects;

namespace TestProjectFork
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEntradaGratis()
        {
            int age = 74;
            string name = "Manuel";
            string result = "nom: " + name + "\nedat: " + age + "\nEl client té entrada gratis.";
            Assert.AreEqual(result, MyProject.PrintCompte(age, name));
        }
        [TestMethod]
        public void TestDescompte()
        {
            int age = 23, discount = 34;
            string name = "Manuel";
            string result = "nom: " + name + "\nedat: " + age + "\nEl client té un descompte de: " + discount;
            Assert.AreEqual(result, MyProject.PrintCompte(age, name, discount));
        }
    }
}