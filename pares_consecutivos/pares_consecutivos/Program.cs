using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares_consecutivos {
    internal class Program {
        static void Main(string[] args) {

            int x, soma;

            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                if (x % 2 == 0) {
                    soma = 5 * x + 20;
                } else {
                    soma = 5 * x + 25;
                }
                Console.WriteLine("SOMA = " + soma);
                Console.Write("Digite um numero inteiro: ");
                x = int.Parse(Console.ReadLine());
            }

        }
    }
}
