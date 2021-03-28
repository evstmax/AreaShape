using AreaShape;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaShapeTest
{
    [TestClass]
    public class TriangleGetAriaTest
    {
        [TestMethod]
        public void TriangleArea_6_8_10_return_24()
        {
            var side1 = 6;
            var side2 = 8;
            var side3 = 10;
            var expArea = 24;

            var triangle = new Triangle(side1, side2, side3);

            var area = triangle.GetArea();

            Assert.AreEqual(expArea, area);
        }

        [TestMethod]
        public void TriangleArea_3_4_10_return()
        {
            var side1 = 3;
            var side2 = 4;
            var side3 = 10;
            
            var triangle = new Triangle(side1, side2, side3);

            var area = triangle.GetArea();

            Assert.AreEqual(0, area);
        }


        [TestMethod]
        public void TriangleArea_negative_return()
        {
            var side1 = -63;
            var side2 = 4;
            var side3 = 10;

            var triangle = new Triangle(side1, side2, side3);

            var area = triangle.GetArea();

            Assert.AreEqual(0, area);
        }

    }
}

