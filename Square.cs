using System;
using System.Linq;

namespace SquareLibrary
{

    public abstract class Figure
    {
        public abstract string CalcSquare();
    }

    public static class FigureSquare
    {
        public static string CalcSquare(Figure figure) => figure.CalcSquare();
    }

    public class Circle : Figure
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public override string CalcSquare()
        {
            return radius > 0 ? $"Площадь круга равна - {Math.PI * radius}." : "Радиус был указан неверно.";
        }
    }

    public class Triangle : Figure
    {
        private double[] sides = new double[3];
        public double[] Sides
        {
            get { return sides; }
            set { sides = value; }
        }

        public override string CalcSquare()
        {
            double p = sides.Sum() / 2;
            if (sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
                return "Длина сторон треугольника указана неверно.";
            else
                return Math.Pow(sides.Max(), 2) == Math.Pow(sides.Sum() - sides.Max(), 2) ?
                    $"Площадь треугольника равна - {Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]))}\nТреугольник прямоугольный" :
                    $"Площадь треугольника равна - {Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]))}\nТреугольник не прямоугольный";
        }
    }
}
