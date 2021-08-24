using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment1
{
    public class Ellipse : Curve
    {
        public Ellipse(double o, double d) : base(o, d)
        { }

        public override Point GetPoint(double t)
        {
            return new Point(O * Math.Cos(t), D * Math.Sin(t));
        }

        public override Vector GetDerivative(double t)
        {
            double dYdT;
            double dXdT;
            double dYdX;

            dYdT = D * Math.Cos(t);
            dXdT = -1.0 * O * Math.Sin(t);
            dYdX = dYdT / dXdT;

            return new Vector(t, dYdX);
        }
    }
}
