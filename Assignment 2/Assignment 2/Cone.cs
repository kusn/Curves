using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Assignment_2
{
    class Cone
    {
        public double Height { get; set; }
        public double Radius { get; set; }
        public int NumberOfSegments { get; set; }
        public Point3D CenterPoint { get; set; }

        public Cone()
        {
            CenterPoint = new Point3D(0.0, 0.0, 0.0);
            Height = 0.0;
            Radius = 0.0;
            NumberOfSegments = 1;
        }

        public Cone(double height, double radius, int numberOfSegments)
        {
            CenterPoint = new Point3D(0.0, 0.0, 0.0);
            Height = height;
            Radius = radius;
            NumberOfSegments = numberOfSegments;
        }

        public Cone(Point3D p0, double height, double radius, int numberOfSegments)
        {
            CenterPoint = p0;
            Height = height;
            Radius = radius;
            NumberOfSegments = numberOfSegments;
        }

        public Cone(double x0, double y0, double z0, double height, double radius, int numberOfSegments)
        {
            CenterPoint = new Point3D(x0, y0, z0);
            Height = height;
            Radius = radius;
            NumberOfSegments = numberOfSegments;
        }

        public List<Triangle> GetTriangles()
        {
            Triangle triangle;
            List<Triangle> triangles = new List<Triangle>();
            Point3D pointH = new Point3D(CenterPoint.X, CenterPoint.Y, CenterPoint.Z + Height);

            for (int i = 1; i <= NumberOfSegments; i++)
            {
                double x1 = Radius * Math.Cos(2.0 * Math.PI * (i - 1) / NumberOfSegments) + CenterPoint.X;
                double x2 = Radius * Math.Cos(2.0 * Math.PI * i / NumberOfSegments) + CenterPoint.X;
                double y1 = Radius * Math.Sin(2.0 * Math.PI * (i - 1) / NumberOfSegments) + CenterPoint.Y;
                double y2 = Radius * Math.Sin(2.0 * Math.PI * i / NumberOfSegments) + CenterPoint.Y;
                Point3D point1 = new Point3D(x2, y2, CenterPoint.Z);
                Point3D point2 = new Point3D(x1, y1, CenterPoint.Z);
                triangle = new Triangle(CenterPoint, point1, point2);
                triangles.Add(triangle);
                triangle = new Triangle(pointH, point1, point2);
                triangles.Add(triangle);
            }
            return triangles;
        }
    }
}
