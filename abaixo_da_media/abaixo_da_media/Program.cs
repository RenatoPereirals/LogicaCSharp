using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abaixo_da_media {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor: ");
            int n = int.Parse(Console.ReadLine());
            
            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            double soma = 0;

            for (int i = 0;i < n; i++) {
                soma += vet[i];
            }

            double media = (double)soma / n;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MEDIA DO VETOR = "+ media.ToString("F3", CI));
            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");

            for (int i = 0; i < n; i++) {
                if (vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}
