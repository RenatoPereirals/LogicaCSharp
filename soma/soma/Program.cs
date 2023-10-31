using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma {
    internal class Program {
        static void Main(string[] args) {

            int x, y;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            int soma = x + y;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
