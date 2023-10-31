using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumo {
    internal class Program {
        static void Main(string[] args) {

            double distancia, consumo, media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine(), CI);
            Console.Write("Combustivel gasto: ");
            consumo = double.Parse(Console.ReadLine(), CI);

            media = distancia / consumo;
            Console.WriteLine("Cosumo medio: " + media.ToString("f3", CI));
        }
    }
}
