using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crescente {
    internal class Program {
        static void Main(string[] args) {

            int x, y;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if (x < y) {
                    Console.WriteLine("CRESCENTE!");
                } else {
                    Console.WriteLine("DECRESCENTE!");
                }
                Console.WriteLine("Digite dois numeros: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}
