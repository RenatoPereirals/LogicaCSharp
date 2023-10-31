using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos numeros voce vai digita: ");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("NUMEROS PARES:");
            int contPares = 0;

            for (int i = 0;i < n; i++) {
                if (vet[i] % 2 == 0) {
                    contPares++;
                    Console.Write(vet[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Quantidade de pares = " + contPares);

        }
    }
}
