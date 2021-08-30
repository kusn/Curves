using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            Vector vector;
            Random rnd = new Random();
            List<Curve> list = new List<Curve>();

            for(int i = 0; i < 3; i++)
            {
                point = new Point(rnd.NextDouble(), rnd.NextDouble());
                vector = new Vector(rnd.NextDouble(), rnd.NextDouble());
                list.Add(new Line(point, vector));
            }

            for (int i = 0; i < 3; i++)
            {
                point = new Point(rnd.NextDouble(), rnd.NextDouble());
                vector = new Vector(rnd.NextDouble(), rnd.NextDouble());
                list.Add(new Ellipse(point, vector));
            }

            foreach(var v in list)
            {
                point = v.GetPoint(Math.PI / 4.0);
                vector = v.GetDerivative(Math.PI / 4.0);
                Console.WriteLine("Параметры O - {0}, D - {1},\nточка: {2}", v.O, v.D, point);
                Console.WriteLine("производная: {0}", vector);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
