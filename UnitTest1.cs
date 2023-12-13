using Projects;

namespace fork_projectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void printCompteTest()
        {
            //Aquesta prova, comprova que si no s'es major de 65 anys, el métode freeEntry retorna false
            //Arrange
            int age = 1;
             
            //Act
            bool notFreeEntry = MyProject.freeEntry(age);

            //Assert
            Assert.IsFalse(notFreeEntry);
        }

        [TestMethod]
        public void printCompteTest2()
        {
            //aquest comprova si retorna true cuan som majors de 65 anys
            //Arrange
            int age = 66;

            //Act
            bool notFreeEntry = MyProject.freeEntry(age);

            //Assert
            Assert.IsTrue(notFreeEntry);
        }
    }
}