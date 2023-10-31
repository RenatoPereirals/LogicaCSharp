using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_de_tres {
    internal class Program {
        static void Main(string[] args) {

            int a, b, c, menor;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c) {
                menor = a;
            } else {
                menor = (Math.Min(b, c));
            }

            Console.WriteLine("Menor = " + menor);
        }
    }
}
