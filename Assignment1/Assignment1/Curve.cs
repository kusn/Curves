using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment1
{
    public class Curve
    {
        public double O { get; set; }
        public double D { get; set; }
        
        private Point p;
        private Vector v;

        public Curve(double o, double d)
        {
            O = o;
            D = d;            
        }        

        virtual public Point GetPoint(double t)
        {            
            return p;
        }

        virtual public Vector GetDerivative(double t)
        {
            return v;
        }
    }
}
