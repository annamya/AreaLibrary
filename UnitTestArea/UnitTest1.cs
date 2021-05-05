using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AreaLibrary.FigureArea;

namespace UnitTestArea
{
    [TestClass]
    public class TestTraingl
    {
        [TestMethod]
        public void TestChackingTrainglRight()
        {
            Traingl traingle = new Traingl(3,4,5);
            Assert.AreEqual("Прямоугольный", traingle.Checking());
        }

        [TestMethod]
        public void TestArea_3and4and5()
        {
            Traingl traingl = new Traingl(3, 4, 5);
            string res = "6";
            Assert.AreEqual(res, traingl.Area());
        }

        [TestMethod]
        public void TestNameTraingl()
        {
            Traingl traingl = new Traingl(3,4,5);
            Assert.AreEqual("Треугольник", traingl.Name());
        }
    }

    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void TestChackingCircle()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual("", circle.Checking());
        }

        [TestMethod]
        public void TestArea_10()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual("314", circle.Area());
        }

        [TestMethod]
        public void TestNameCircle()
        {
            Circle circle = new Circle(6);
            Assert.AreEqual("Круг", circle.Name());
        }
    }
}
