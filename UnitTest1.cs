using Projects;
namespace ForkTetst
{
    [TestClass]
    public class ForkTests
    {
        [TestMethod]
        public void TestValidateNoFreeEntrance()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            int age = 64;
            string name = "carlos";
            MyProject.PrintBill(age, name);

            string expected = "*******************************************\n*******************************************\n*********** Control clients ***************\n*******************************************\n*******************************************\nnom: carlos\nedat: 64\nEl client no té entrada gratis.";
            Assert.AreEqual(expected, sw.ToString().Trim().Replace("\r\n", "\n"));
        }
        [TestMethod]
        public void TestValidateFreeEntrance()
        {
            StringWriter sw = new();
            Console.SetOut(sw);
            int age = 65;
            string name = "carlos";
            MyProject.PrintBill(age, name);

            string expected = "*******************************************\n*******************************************\n*********** Control clients ***************\n*******************************************\n*******************************************\nnom: carlos\nedat: 65\nEl client té entrada gratis.";
            Assert.AreEqual(expected, sw.ToString().Trim().Replace("\r\n", "\n"));
        }
        [TestMethod]
        public void TestValidateNoRetired()
        {
            int age = 64;
            bool result=MyProject.Retired(age);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestValidateRetired()
        {
            int age = 65;
            bool result = MyProject.Retired(age);
            Assert.IsTrue(result);
        }
    }
}