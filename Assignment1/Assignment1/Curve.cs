using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment1
{
    public delegate double Fun(double t);

    public class Curve
    {
        /*private double x, y;

        private Point o;
        private Vector d;*/

        public Fun xFun, yFun;

        public Point O { get; set; }
        public Vector D { get; set; }

        public Curve(Point o, Vector d)
        {
            O = o;
            D = d;            
        }

        public Curve(Point o, Vector d, Fun xFun, Fun yFun)
        {
            O = o;
            D = d;
            this.xFun = xFun;
            this.yFun = yFun;            
        }        

        public Point GetPoint(double t)
        {            
            double x = O.X + D.X * xFun(t);
            double y = O.Y + D.Y * yFun(t);
            return new Point(x, y);
        }

        virtual public Vector GetDerivative(double t)
        {
            Vector v = new Vector();
            return v;
        }
    }
}
