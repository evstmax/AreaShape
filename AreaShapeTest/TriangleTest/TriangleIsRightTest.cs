using AreaShape;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaShapeTest
{
    [TestClass]
   public class TriangleIsRightTest
    {
        [TestMethod]
        public void Triangle_Right()
        {
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;

            var triangle = new Triangle(side1, side2, side3);

            var area = triangle.IsRight();

            Assert.AreEqual(true, area);
        }
    }
}
