using static System.Math;

namespace AreaShape
{
    /// <summary>
    /// 
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Вычисленеие площади круга
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            if (Radius <= 0)
            {
                return 0;
            }
            return PI * Pow(Radius, 2);
        }
    }
}
