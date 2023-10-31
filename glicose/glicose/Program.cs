using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glicose {
    internal class Program {
        static void Main(string[] args) {

            double medida;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a medida da glicose: ");
            medida = double.Parse(Console.ReadLine(), CI);

            if (medida <= 100) {
                Console.WriteLine("Clasiificação: nornal");
            } else if (medida <= 140) {
                Console.WriteLine("Classificação: elevado");
            } else {
                Console.WriteLine("Classificação: diabetes");
            }

        }
    }
}
