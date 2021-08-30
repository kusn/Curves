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

        // Создание конуса по умолчанию
        public Cone()
        {
            CenterPoint = new Point3D(0.0, 0.0, 0.0);
            Height = 0.0;
            Radius = 0.0;
            NumberOfSegments = 1;
        }

        // Создание конуса через высоту, радиус и количество сегментов с центром основания в нуле
        public Cone(double height, double radius, int numberOfSegments)
        {
            CenterPoint = new Point3D(0.0, 0.0, 0.0);
            Height = height;
            Radius = radius;
            NumberOfSegments = numberOfSegments;
        }

        // Создание конуса через высоту, радиус и количество сегментов с центром основания в произвольной точке через point
        public Cone(Point3D p0, double height, double radius, int numberOfSegments)
        {
            CenterPoint = p0;
            Height = height;
            Radius = radius;
            NumberOfSegments = numberOfSegments;
        }

        // Создание конуса через высоту, радиус и количество сегментов с центром основания в произвольной точке через координаты
        public Cone(double x0, double y0, double z0, double height, double radius, int numberOfSegments)
        {
            CenterPoint = new Point3D(x0, y0, z0);
            Height = height;
            Radius = radius;
            NumberOfSegments = numberOfSegments;
        }

        // Создаём список треугольников
        public List<Triangle> GetTriangles()
        {
            double x1, x2, y1, y2;
            Point3D point1, point2;
            Triangle triangle;
            List<Triangle> triangles = new List<Triangle>();
            Point3D pointH = new Point3D(CenterPoint.X, CenterPoint.Y, CenterPoint.Z + Height);     //Создаем точку вершины

            for (int i = 1; i <= NumberOfSegments; i++)
            {
                //Вычисляем точки на окружности
                x1 = Radius * Math.Cos(2.0 * Math.PI * (i - 1) / NumberOfSegments) + CenterPoint.X;
                x2 = Radius * Math.Cos(2.0 * Math.PI * i / NumberOfSegments) + CenterPoint.X;
                y1 = Radius * Math.Sin(2.0 * Math.PI * (i - 1) / NumberOfSegments) + CenterPoint.Y;
                y2 = Radius * Math.Sin(2.0 * Math.PI * i / NumberOfSegments) + CenterPoint.Y;
                //Создаём точки на окружности (првая точка на оси Х)
                point1 = new Point3D(x2, y2, CenterPoint.Z);
                point2 = new Point3D(x1, y1, CenterPoint.Z);
                triangle = new Triangle(CenterPoint, point1, point2);       //Треугольник в основании. Вершины по часовой стрелке
                triangles.Add(triangle);
                triangle = new Triangle(pointH, point1, point2);            //Боковые грани
                triangles.Add(triangle);
            }
            return triangles;
        }

        //Создаём список нормалей
        public List<Vector3D> GetVertexes(Cone cone)
        {
            Vector3D u1, u2, v1, v2, n1, n2, n;
            List<Vector3D> vertexes = new List<Vector3D>();
            List<Triangle> triangles = cone.GetTriangles();

            int i = 1;
            while(i < triangles.Count)
            {
                if (i == triangles.Count - 1)
                {
                    u1 = triangles[i].Point3 - triangles[i].Point2;
                    v1 = triangles[i].Point3 - triangles[i].Point1;
                    n1 = Vector3D.CrossProduct(u1, v1);
                    u2 = triangles[1].Point3 - triangles[1].Point2;             //В листе треугольников хранятся треугольники основания с 0 элемента. 0 эелемент - треугольник основания
                    v2 = triangles[1].Point3 - triangles[1].Point1;
                    n2 = Vector3D.CrossProduct(u2, v2);
                    n = 0.5 * (n1 + n2);                                        // Нормаль основания не учитываем, т.к. сглаживание угла между основанием и гранями не требуется                    
                }
                else
                {
                    u1 = triangles[i].Point3 - triangles[i].Point2;
                    v1 = triangles[i].Point3 - triangles[i].Point1;
                    n1 = Vector3D.CrossProduct(u1, v1);
                    u2 = triangles[i + 2].Point3 - triangles[i + 2].Point2;
                    v2 = triangles[i + 2].Point3 - triangles[i + 2].Point1;
                    n2 = Vector3D.CrossProduct(u2, v2);
                    n = 0.5 * (n1 + n2);
                }
                vertexes.Add(n);
                i = i + 2;
            }
            return vertexes;
        }
    }
}
