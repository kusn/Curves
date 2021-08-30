using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Assignment_2
{
    public class Triangle
    {
        public Point3D Point1 { get; set; }
        public Point3D Point2 { get; set; }
        public Point3D Point3 { get; set; }

        public Triangle()
        {
            Point1 = new Point3D();
            Point2 = new Point3D();
            Point3 = new Point3D();
        }

        public Triangle(double x1, double y1, double z1, double x2, double y2, double z2, double x3, double y3, double z3)
        {
            Point1 = new Point3D(x1, y1, z1);
            Point2 = new Point3D(x2, y2, z2);
            Point3 = new Point3D(x3, y3, z3);
        }

        public Triangle(Point3D p1, Point3D p2, Point3D p3)
        {
            Point1 = p1;
            Point2 = p2;
            Point3 = p3;
        }        

        public string ToString()
        {
            string s;
            s = Point1.ToString() + "\n" + Point2.ToString() + "\n" + Point3.ToString();
            return s;
        }
    }
}
