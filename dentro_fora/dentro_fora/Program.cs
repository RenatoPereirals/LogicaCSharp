using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dentro_fora {
    internal class Program {
        static void Main(string[] args) {

            int n, x, dentro, fora;

            Console.Write("Quantos numeros voce vai digitar: ");
            n = int.Parse(Console.ReadLine());

            
            dentro = 0; fora = 0;

            for (int i = 1; i <= n; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                if (x < 10 || x > 20) {
                    fora++;
                } else {
                    dentro++;
                }
            }

            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");

        }
    }
}
