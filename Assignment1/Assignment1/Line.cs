using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment1
{
    class Line : Curve
    {
        public Line(double o, double d) : base(o, d)
        { }

        public override Point GetPoint(double t)
        {
            
            return new Point(t * O * Math.Sin(t), t * D * Math.Cos(t));
        }

        public override Vector GetDerivative(double t)
        {
            double dYdT;
            double dXdT;
            double dYdX;

            dYdT = D * (Math.Cos(t) + t * (-1.0 * Math.Sin(t)));
            dXdT = O * (Math.Sin(t) + t * Math.Cos(t));
            dYdX = dYdT / dXdT;

            return new Vector(t, dYdX);
        }
    }
}
