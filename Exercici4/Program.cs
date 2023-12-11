using System;

namespace MyApplication
{

    class CalculateAreas
    {

        static void Main()
        {
            const int Zero = 0;

            const string MsgSquare = "Introdueix la mesura d'un costat del quadrat: ";
            const string MsgRectangleBase = "Introdueix la base del rectangle: ";
            const string MsgRectangleHeight = "Introdueix l'altura del rectangle: ";
            const string MsgCircleRadius = "Introdueix el radi del cercle: ";
            const string MsgPentagonSide = "Introdueix la mesura d'un costat del pentàgon: ";

            int squareSide, rectangleBase, rectangleHeight, circleRadius, pentagonSide;

            // Square Values
            do
            {
                Console.WriteLine(MsgSquare);
                squareSide = Convert.ToInt32(Console.ReadLine());
            }while (squareSide <= Zero);

            // Rectangle Values
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

            //Circle Values
            do
            {
                Console.WriteLine(MsgCircleRadius);
                circleRadius = Convert.ToInt32(Console.ReadLine());
            } while (circleRadius <= Zero);

            //Triangle Values
            do
            {
                Console.WriteLine(MsgPentagonSide);
                pentagonSide = Convert.ToInt32(Console.ReadLine());
            } while (pentagonSide <= Zero);

        }

    }

}