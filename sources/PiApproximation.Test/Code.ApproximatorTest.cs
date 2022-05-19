using NUnit.Framework;
using System;

namespace PiApproximation.Test
{
    [TestFixture]
    public partial class ApproximatorTest
    {
        [Test]
        public void Approximate_WhenWhenTheePointsWithTwoInside_ThenShouldReturn10()
        {
            var point1 = new Point(0.5, 0.5);
            var point2 = new Point(0.5, 0.5);
            var point3 = new Point(1, 1);

            var points = new[]
            {
                point1,
                point2,
                point3,
            };

            var calc = GetTarget();

            var pi = calc.Approximate(points);

            Assert.That(pi, Is.EqualTo(8/3d).Within(0.001));
        }
    }
}
