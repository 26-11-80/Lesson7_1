using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 2;
            double y1 = 3;
            double z1 = 4;

            double x2 = 2;
            double y2 = 3;
            double z2 = 4.5;

            double s1 = CalcPloshad(x1, y1, z1);
            Console.WriteLine(s1);
            double s2 = CalcPloshad(x2, y2, z2);
            Console.WriteLine(s2);

            if (s1 > s2) Console.WriteLine("Площадь первого треугольника больше");
            if (s2 > s1) Console.WriteLine("Площадь второго треугольника больше");

            Console.ReadKey();
        }

        static double CalcPloshad(double x, double y, double z)
        {
            double p = (double)(x + y + z) / 2;
            double s = (double) Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return s;
        }

        

        }
    }

