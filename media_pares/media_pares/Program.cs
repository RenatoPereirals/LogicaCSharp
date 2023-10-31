using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_pares {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            int contPares = 0;
            int soma = 0;

            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    contPares++;
                    soma += vet[i];
                }
            }

            double media = (double) soma / contPares;

            if (contPares != 0) {
                Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F1", CI));
            } else {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
        }
    }
}
