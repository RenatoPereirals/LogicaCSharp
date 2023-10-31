using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circulo {
    internal class Program {
        static void Main(string[] args) {

            double r, area;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o raio do circulo: ");
            r = double.Parse(Console.ReadLine(), CI);

            area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("AREA = " + area.ToString("F3", CI));

        }
    }
}
