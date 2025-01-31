using LabTwoLib;

namespace LabTwoTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double num1 = 10;
            double num2 = 20;

            //Act
            double maxNum = LabTwo.FindMax(num1, num2);

            //Assert
            Assert.IsTrue(maxNum == 20);
        }
        [TestMethod]
        public void TestThreeNum()
        {
            //Arrange
            double num1 = 10;
            double num2 = 20;
            double num3 = 30;

            //Act
            double maxNum = LabTwo.FindMax(num1, num2, num3);

            //Assert
            Assert.IsTrue(maxNum == 30);
        }
        [TestMethod]
        public void TestArray()
        {

            //Arrange
            double[] arr = new double[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i + 1) * 10;
            }

            //Act
            double maxNum = LabTwo.FindMax(arr);

            //Assert
            Assert.IsTrue(maxNum == 100);

        }
        [TestMethod]
        public void TestList()
        {

            //Arrange
            List<double> arr = new List<double>();

            for (int i = 1; i <= 10; i++)
            {
                arr.Add(i * 10);
            }

            //Act
            double maxNum = LabTwo.FindMax(arr);

            //Assert
            Assert.IsTrue(maxNum == 100);

        }
    }
}
