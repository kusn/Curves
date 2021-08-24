using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, r;
            int n;
            List<Triangle> triangles = new List<Triangle>();
            
            Console.WriteLine("Введите высоту конуса");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус конуса");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число сегментов конуса");
            n = Convert.ToInt32(Console.ReadLine());

            Cone cone = new Cone(h, r, n);
            triangles = cone.GetTriangles();

            foreach (var v in triangles)
            {
                Console.WriteLine(v.ToString() + "\n");
            }
        }
    }
}
