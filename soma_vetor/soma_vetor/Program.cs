using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_vetor {
    internal class Program {
        static void Main(string[] args) {

            int n;
            double soma, media; 

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos numeros voce vai digitar: ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("VALORES = ");
            for (int i = 0;i < n; i++) {
                Console.Write(vet[i].ToString("F1", CI) + " ");
            }
            soma = 0;

            Console.WriteLine();
            for (int i = 0; i < n; i++) {
                soma += vet[i];
            }

            media = soma / n;

            Console.WriteLine("SOMA = " + soma.ToString("F1", CI));
            Console.WriteLine("MEDIA = " + media.ToString("F1", CI));

        }
    }
}
