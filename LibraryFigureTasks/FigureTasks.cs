using System;
using LibraryFigure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryFigureTasks
{
    [TestClass]
    public class FigureTasks
    {
        [TestMethod]
        public void CircleArea_10_314reterned()
        {
            double r = 10;
            double expected = 314;

            Figure f = new Figure();

            double actual = f.DesideMethodFigureType(r);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DesideTriangleArea_5_4_3_6reterned()
        {
            double a = 5;
            double b = 4;
            double c = 3;
            double expected = 6;

            Figure f = new Figure();

            double actual = f.DesideMethodFigureType(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Данная фигура не существует")]
        public void DesideMethodFigureType()
        {
            Figure f = new Figure();
            double actual = f.DesideMethodFigureType();
        }
    }
}
