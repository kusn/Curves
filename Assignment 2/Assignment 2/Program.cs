using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, r;
            int n;
            List<Triangle> triangles = new List<Triangle>();
            List<Vector3D> vertexes = new List<Vector3D>();
            
            Console.WriteLine("Введите высоту конуса");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус конуса");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число сегментов конуса");
            n = Convert.ToInt32(Console.ReadLine());

            Cone cone = new Cone(h, r, n);
            triangles = cone.GetTriangles();
            vertexes = cone.GetVertexes(cone);

            Console.WriteLine("\n" + $"Всего треугольников - {triangles.Count}");
            Console.WriteLine("Список треугольников:");
            
            foreach (var v in triangles)
            {
                Console.WriteLine(v.ToString() + "\n");
            }

            Console.WriteLine("Список нормалей:" + "\n");
            foreach (var v in vertexes)
            {
                Console.WriteLine(v.ToString() + "\n");
            }

            Console.ReadLine();
        }
    }
}
