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
        static double XF(double t)
        {
            return  Math.Cos(t);
        }

        static double YF(double t)
        {
            return Math.Sin(t);
        }

        public Ellipse(Point o, Vector d) : base(o, d)
        {
            xFun = new Fun(XF);
            yFun = new Fun(YF);
        }

        public override Vector GetDerivative(double t)
        {
            double dXdT, dYdT;

            dXdT = -1.0 * D.X * Math.Sin(t);
            dYdT = D.Y * Math.Cos(t); 
            return new Vector(dXdT, dYdT);
        }
    }
}
