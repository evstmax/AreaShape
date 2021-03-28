using AreaShape;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Math;

namespace AreaShapeTest
{
    [TestClass]

    public class CircleGetAriaTest
    {
        [TestMethod]
        public void CircleArea_5_return()
        {
            var radius = 5;

            var circle = new Circle(radius);

            var area = circle.GetArea();
            var expArea = PI * Pow(radius, 2);

            Assert.AreEqual(expArea, area);
        }

        [TestMethod]
        public void CircleArea_0_return()
        {
            var radius = 0;

            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CircleArea_negative_return()
        {
            var radius = -10;

            var circle = new Circle(radius);

            var area = circle.GetArea();

            Assert.AreEqual(0, area);
        }
    }
}

