using DreieckService;
using NUnit.Framework;

namespace ProjectDreieck.Tests
{
    [TestFixture]
    public class Descriptions
    {
        [TestCase( new double[] { 0, 1, 2 }, "an invalid triangle")]
        [TestCase( new double[] { 1, 1, 1.5 }, "a valid isosceles triangle")]
        [TestCase( new double[] { 2, 2, 2 }, "a valid equilateral triangle")]
        [TestCase( new double[] { 3, 4, 5 }, "a valid right triangle")]
        [TestCase( new double[] { 0.0001, 1, 1.0001 }, "an invalid triangle")]
        [TestCase( new double[] { -3, -1, -3 }, "an invalid triangle")]
        public void VerifyDescriptions(double[] sides, string expectedDescription)
        {
            Triangle tri = new Triangle(sides);
            Assert.AreEqual(expectedDescription, tri.GetDescription());
        }
    }
}
