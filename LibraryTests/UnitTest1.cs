using ClassLibraryFigures;

namespace LibraryTests
{
    [TestClass]
    public class AreaCompilatorTests
    {
        [TestMethod]
        public void TestgetTriangleArea()
        {
            double expected = 6;
            AreaCompilator compilator = new AreaCompilator();
            double result = compilator.getTriangleArea(3,4,5);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestgetCircleArea()
        {
            double expected = 4*Math.PI;
            AreaCompilator compilator = new AreaCompilator();
            double result = compilator.getCircleArea(2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestgetIfTriangleisright()
        {
            bool expected = true;
            AreaCompilator compilator=new AreaCompilator();
            bool result=compilator.getIfTriangleisright(3,4,5);
            Assert.AreEqual(expected, result);
        }
    }
}