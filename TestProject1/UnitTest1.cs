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
    
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            const int radius = 425;
            const double resultExpected = 567451.5;

            //Act

            double result = CalculateAreas.CircleArea(radius);

            //Assert
            Assert.AreEqual(result, resultExpected);
        }
    }

    [TestClass]
    public class UnitTestPentagon
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            const int pentagonSide = 10, apothem = 4;
            const double resultExpected = 100;

            //Act

            double result = CalculateAreas.PentagonArea(pentagonSide, apothem);

            //Assert
            Assert.AreEqual(result, resultExpected);
        }
    }

}