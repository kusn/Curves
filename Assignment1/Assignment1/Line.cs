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
        static double XF(double t)
        {
            return t;
        }

        static double YF(double t)
        {
            return t;
        }

        public Line(Point o, Vector d) : base(o, d)
        {
            xFun = new Fun(XF);
            yFun = new Fun(YF);
        }

        public override Vector GetDerivative(double t)
        {
            
            return new Vector(D.X, D.Y);
        }
    }
}
