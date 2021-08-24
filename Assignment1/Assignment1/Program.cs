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

            list.Add(new Line(rnd.NextDouble(), rnd.NextDouble()));
            list.Add(new Line(rnd.NextDouble(), rnd.NextDouble()));
            list.Add(new Line(rnd.NextDouble(), rnd.NextDouble()));
            list.Add(new Ellipse(rnd.NextDouble(), rnd.NextDouble()));
            list.Add(new Ellipse(rnd.NextDouble(), rnd.NextDouble()));
            list.Add(new Ellipse(rnd.NextDouble(), rnd.NextDouble()));

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
