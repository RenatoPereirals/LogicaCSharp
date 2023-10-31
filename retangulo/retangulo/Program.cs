using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangulo {
    internal class Program {
        static void Main(string[] args) {

            double largura, altura, area, perimetro, diagonal;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digeite a largura: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digeite a altura: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimetro = 2 * (altura + largura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
        }
    }
}
