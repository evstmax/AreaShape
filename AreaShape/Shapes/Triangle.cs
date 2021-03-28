using static System.Math;

namespace AreaShape
{
	public class Triangle : IShape
    {
        /// <summary>
        /// Длина первой стороны треугольника
        /// </summary>
        public double Side1 { get; set; }

        /// <summary>
        /// Длина второй стороны треугольника
        /// </summary>
        public double Side2 { get; set; }

        /// <summary>
        /// Длина третьей стороны треугольника
        /// </summary>
        public double Side3 { get; set; }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="side1">Длина первой стороны треугольника</param>
        /// <param name="side2">Длина второй стороны треугольника</param>
        /// <param name="side3">Длина третьей стороны треугольника</param>
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        /// <inheritdoc />
        /// <remarks>
        /// Вычисление площади треугольника
        /// </remarks>
        public double GetArea()
        {
            
            if (!IsCheck())
            {
                return 0;
            }
            
            var p = (Side1 + Side2 + Side3) / 2;

            return Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        /// <summary>
        /// Длинны сторон имеют положительные значения 
        /// Каждая сторона больше суммы двух других
        /// </summary>
        public bool IsCheck()
        {
            if (Side1 <= 0 || Side2 <= 0 || Side3 <= 0)
            {
                return false;
            }

            if (Side1 + Side2 < Side3 || Side1 + Side3 < Side2 || Side2 + Side3 < Side1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight()
        {
            if (!IsCheck())
            {
                return false;
            }
            
            return
                (Pow(Side1, 2) == Pow(Side2, 2) + Pow(Side3, 2) || Pow(Side2, 2) == Pow(Side1, 2) + Pow(Side3, 2) || Pow(Side3, 2) == Pow(Side1, 2) + Pow(Side2, 2));
        }
    }
}
