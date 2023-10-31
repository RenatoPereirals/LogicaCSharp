using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadora {
    internal class Program {
        static void Main(string[] args) {

            int minutos;
            double pagar;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if (minutos <= 100) {
                pagar = 50;
            } else {
                pagar = (double)(minutos - 100) * 2 + 50;
            }

            Console.WriteLine("Valor a pagar: R$ " + pagar.ToString("f2", CI));

        }
    }
}
