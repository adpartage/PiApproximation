using System.Collections.Generic;

namespace PiApproximation
{
    public class PiApproximator : IPiApproximator
    {
        public double Approximate(IEnumerable<Point> points)
        {
            var insideCount = 0;
            var length = 0;
            foreach (var pt in points)
            {
                length++;
                if (IsInside(pt))
                {
                    insideCount++;
                }
            }

            var pi = 4d * insideCount / length;

            return pi;
        }

        private static bool IsInside(Point pt)
        {
            return pt.X * pt.X + pt.Y * pt.Y < 1;
        }
    }
}