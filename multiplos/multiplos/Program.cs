using System;
using System.Globalization;

namespace multiplos {
    internal class Program {
        static void Main(string[] args) {

            int x, y, troca;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y) {
                troca = x;
                x = y;  
                y = troca;
            }

            if (x % y == 0) {
                Console.WriteLine("Sao multiplos");
            } else {
                Console.WriteLine("Nao sao multiplos");
            }

        }
    }
}
