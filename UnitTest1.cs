using Projects;
namespace fork_project_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 32;
            string name = "Paco", free = "El client no té entrada gratis.",
            expected = $"Nom: {name}. Edat: {age}. {free}";
            Assert.AreEqual(expected, MyProject.PrintCompte(age, name));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int age = 69;
            string name = "Josué", free = "El client no té entrada gratis.",
            expected = $"Nom: {name}. Edat: {age}. {free}";
            Assert.AreNotEqual(expected, MyProject.PrintCompte(age,name));
        }
        [TestMethod]
        public void TestMethod3()
        {
            int age = 94;
            string name = "Mari Carmen", free = "El client té entrada gratis.",
            expected = $"Nom: {name}. Edat: {age}. {free}";
            Assert.AreEqual(expected, MyProject.PrintCompte(age,name));
        }
    }
}