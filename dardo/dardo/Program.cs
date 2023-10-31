using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dardo {
    internal class Program {
        static void Main(string[] args) {

            double a, b, c, maior;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digiete as tres distancias:");
            a = double.Parse(Console.ReadLine(), CI);
            b = double.Parse(Console.ReadLine(), CI);
            c = double.Parse(Console.ReadLine(), CI);

            if (a > b && a > c) {
                maior = a;
            } else {
                maior = Math.Max(b, c);
            }

            Console.WriteLine("MAIOR = " + maior.ToString("f2", CI));
        }
    }
}
