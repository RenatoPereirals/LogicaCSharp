using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baskara {
    internal class Program {
        static void Main(string[] args) {

            double a, b, c, delta, x1, x2;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine(), CI);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta >= 0 && a != 0) {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("X1 = " + x1.ToString("f4", CI));
                Console.WriteLine("X2 = " + x2.ToString("f4", CI));

            } else {
                Console.WriteLine("Esta equacao nao possui raizes reais");
            }    
        }
    }
}
