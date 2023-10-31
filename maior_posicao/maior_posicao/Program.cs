using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_posicao {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            double maior = vet[0];
            int posicao = 0;

            for (int i = 1; i < n; i++) {
                if (vet[i] > maior) {
                    maior = vet[i];
                    posicao = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MAIO VALOR = " + maior.ToString("F1", CI));
            Console.WriteLine("POSICAO DO MAIO VALOR = " + posicao);

        }
    }
}
