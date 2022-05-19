using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace PiApproximation.Test
{
    [TestFixture]
    public partial class ApproximatorTest
    {
        private IPiApproximator GetTarget()
        {
            return new PiApproximator();
        }

        [Test]
        public void Approximate_When10MillionPoints_ThenApproximationShouldBeWithin3Decimals()
        {
            var calc = GetTarget();

            var pi = calc.Approximate(GetPoints(10000000));

            Assert.That(pi, Is.EqualTo(Math.PI).Within(0.001));
        }

        private static IEnumerable<Point> GetPoints(int size)
        {
            var rand = new Random();
            var i = 1;
            while (i++ < size)
            {
                yield return new Point(rand.NextDouble(), rand.NextDouble());
            }
        }
    }
}
