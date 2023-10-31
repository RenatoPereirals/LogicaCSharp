using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace alturas {
    internal class Program {
        static void Main(string[] args) {
                                   
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantas pessoas serao digitadas: ");
            int n = int.Parse(Console.ReadLine());

            String[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);
            }

            double soma = 0;

            for (int i = 0;i < n; i++) {
                soma += altura[i];
            }

            double media = soma / n;

            int menores16 = 0;

            for(int i = 0; i <n; i++) {
                if (idade[i] < 16) {
                    menores16++;
                }
            }

            double pMenores16 = (double)menores16 / n * 100;

            Console.WriteLine("Altura media = "+ media.ToString("F2", CI));
            Console.WriteLine("Pessoas menores de 16 anos = " + pMenores16.ToString("F2", CI) + "%");

            for (int i = 0; i < n; i++) { 
                if (idade[i] < 16) {
                    Console.WriteLine(nome[i]);
                }
            }


        }
    }
}
