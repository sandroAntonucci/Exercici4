using System;
using System.Diagnostics.Contracts;

namespace MyApplication
{

    public static class CalculateAreas
    {

        public static void Main()
        {
            const int Zero = 0;

            const string MsgSquare = "Introdueix la mesura d'un costat del quadrat: ";
            const string MsgResultSquare = "L'àrea del quadrat és {0}.";
            const string MsgRectangleBase = "Introdueix la base del rectangle: ";
            const string MsgRectangleHeight = "Introdueix l'altura del rectangle: ";
            const string MsgResultRectangle = "L'àrea del rectangle és {0}.";
            const string MsgCircleRadius = "Introdueix el radi del cercle: ";
            const string MsgResultCircle = "L'àrea del cercle és {0}.";
            const string MsgPentagonSide = "Introdueix la mesura del costat del pentàgon: ";
            const string MsgPentagonApothem = "Introdueix la mesura de l'apotema del pentàgon: ";
            const string MsgResultPentagon = "L'àrea del rectangle és {0}.";

            int squareSide, rectangleBase, rectangleHeight, circleRadius, pentagonSide, apothem;

            // Square
            do
            {
                Console.WriteLine(MsgSquare);
                squareSide = Convert.ToInt32(Console.ReadLine());
            }while (squareSide <= Zero);

            Console.WriteLine(MsgResultSquare, SquareArea(squareSide));

            // Rectangle 
            do
            {
                Console.WriteLine(MsgRectangleBase);
                rectangleBase = Convert.ToInt32(Console.ReadLine());
            } while (rectangleBase <= Zero);

            do
            {
                Console.WriteLine(MsgRectangleHeight);
                rectangleHeight = Convert.ToInt32(Console.ReadLine());
            } while (rectangleHeight <= Zero);

            Console.WriteLine(MsgResultRectangle, RectangleArea(rectangleBase, rectangleHeight));

            // Circle
            do
            {
                Console.WriteLine(MsgCircleRadius);
                circleRadius = Convert.ToInt32(Console.ReadLine());
            } while (circleRadius <= Zero);

            Console.WriteLine(MsgResultCircle, CircleArea(circleRadius));

            // Pentagon
            do
            {
                Console.WriteLine(MsgPentagonSide);
                pentagonSide = Convert.ToInt32(Console.ReadLine());
            } while (pentagonSide <= Zero);

            do
            {
                Console.WriteLine(MsgPentagonApothem);
                apothem = Convert.ToInt32(Console.ReadLine());
            } while (apothem <= Zero);

            Console.WriteLine(MsgResultPentagon, PentagonArea(pentagonSide, apothem));

        }

        public static int SquareArea(int squareSide)
        {
            return squareSide * squareSide;
        }

        public static int RectangleArea(int rectangleBase, int rectangleHeight)
        {
            return rectangleBase * rectangleHeight;
        }

        public static double CircleArea(int circleRadius)
        {
            const double Pi = 3.1416;
            return Double.Round(Pi*(circleRadius*circleRadius), 2);
        }

        public static double PentagonArea(int pentagonSide, int apothem)
        {
            return (5*pentagonSide*apothem)/2;
        }

    }

}