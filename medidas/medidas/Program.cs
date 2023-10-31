using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidas {
    internal class Program {
        static void Main(string[] args) {

            double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida de A: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida de B: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida de C: ");
            c = double.Parse(Console.ReadLine(), CI);

            areaQuadrado = Math.Pow(a, 2);
            areaTriangulo = a * b / 2;
            areaTrapezio = (a + b) * c / 2;

            Console.WriteLine("AREA DO QUADRADO: " + areaQuadrado.ToString("f4", CI));
            Console.WriteLine("AREA DO TRIANGULO: " + areaTriangulo.ToString("f4", CI));
            Console.WriteLine("AREA DO TRAPEZIO: " + areaTrapezio.ToString("f4", CI));
        }
    }
}
