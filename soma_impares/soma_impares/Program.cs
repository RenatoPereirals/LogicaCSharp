using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_impares {
    internal class Program {
        static void Main(string[] args) {

            int x, y, soma;

            Console.WriteLine("Digite dois numeros");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y) {
                int troca = x; x = y; y = troca;   
            }

            soma = 0;

            for (int i = x + 1; i < y; i++) { 
                if (i % 2 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine("Soma dos impares: " + soma);
        }
    }
}
