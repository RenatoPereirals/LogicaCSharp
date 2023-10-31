using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativos {
    internal class Program {
        static void Main(string[] args) {

            int n;

            Console.Write("Quantos numeros voce vai digitar: ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS: ");
            for (int i = 0;i < n; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
