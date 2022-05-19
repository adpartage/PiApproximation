using System.Collections.Generic;

namespace PiApproximation
{
    public interface IPiApproximator
    {
        double Approximate(IEnumerable<Point> points);
    }
}