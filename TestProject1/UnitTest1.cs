using MyApplication;

namespace TestProject1
{
    [TestClass]
    public class UnitTestSquare 
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            const int squareSide = 10;
            const int resultExpected = 100;

            //Act

            int result = CalculateAreas.SquareArea(squareSide);

            //Assert
            Assert.AreEqual(result, resultExpected);

        }
    }

    [TestClass]
    public class UnitTestRectangle
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            const int rectangleBase = 20, rectangleHeight = 5;
            const int resultExpected = 100;

            //Act

            int result = CalculateAreas.RectangleArea(rectangleBase, rectangleHeight);

            //Assert
            Assert.AreEqual(result, resultExpected);

        }
    }
}