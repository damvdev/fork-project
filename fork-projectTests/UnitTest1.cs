using Projects;

namespace fork_projectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoesHeaderDisplayCorrectly()
        {
            StringWriter sw = new StringWriter();
            string expected = "*******************************************\n*******************************************\n" +
                              "*********** Control clients ***************\n*******************************************\n" +
                              "*******************************************\r\n";

            Console.SetOut(sw);

            MyProject.PrintHeader();
                
            Assert.AreEqual<string>(expected, sw.ToString());
         
        }
        [TestMethod]
        public void ClientGetsFreeTicket()
        {
            int age = 65;

            Assert.IsTrue(MyProject.EntradaGratis(age));
        }
        [TestMethod]
        public void ClientDoesNotGetFreeTicket()
        {
            int age = 64;

            Assert.IsFalse(MyProject.EntradaGratis(age));
        }
        [TestMethod]
        public void PrintedMessegeIsCorrectResponse()
        {
            int age = 64;
            string name = "Tester";
            string expected = "*******************************************\n*******************************************\n" +
                              "*********** Control clients ***************\n*******************************************\n" +
                              "*******************************************\r\n" +
                              $"nom: {name}\r\nedat: {age}\r\nEl client no té entrada gratis.\r\n";
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            MyProject.PrintCompte(age,name);

            Assert.AreEqual(expected, sw.ToString());
        }
    }
}