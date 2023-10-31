using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_ponderada {
    internal class Program {
        static void Main(string[] args) {

            int n;
            double a, b, c;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite tres numeros:");

            for (int i = 0; i < n; i++) {
                a = double.Parse(Console.ReadLine(), CI);
                b = double.Parse(Console.ReadLine(), CI);
                c = double.Parse(Console.ReadLine(), CI);

                double media = (a * 2 + b * 3 + c * 5) / 10;
                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));
            }


        }
    }
}
