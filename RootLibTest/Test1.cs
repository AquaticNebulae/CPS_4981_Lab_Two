using RootLib;
namespace RootLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquareRootOf4()
        {

            double a = 4; // arrange
            double expected = 2;

            double actual = Root.MyRoot(a); // act

            Assert.AreEqual(expected, actual); // assert
        }
        [TestMethod]
        public void TestSquareRootOf9()
        {

            double a = 9; // arrange
            double expected = 3;

            double actual = Root.MyRoot(a); // act

            Assert.AreEqual(expected, actual); // assert
        }
    }
}
