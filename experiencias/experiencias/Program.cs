using System;
using System.Globalization;

namespace experiencias {
    internal class Program {
        static void Main(string[] args) {

            char tipoCobaia;
            int n, total, totalCoelho, totalRato, totalSapo, qtdCobaias;
            double pCoelho, pRato, pSapo;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos voce vai testar? ");
            n = int.Parse(Console.ReadLine());

            totalCoelho = 0;
            totalRato = 0;
            totalSapo = 0;

            for (int i = 0; i < n; i++) {
                Console.Write("Quantidade de cobaisa: ");
                qtdCobaias = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                tipoCobaia = char.Parse(Console.ReadLine());

                switch (tipoCobaia) {
                    case 'C': totalCoelho += qtdCobaias; break;
                    case 'R': totalRato += qtdCobaias; break;
                    case 'S': totalSapo += qtdCobaias; break;
                }     
            }

            total = totalCoelho + totalRato + totalSapo;
            pCoelho = (double)totalCoelho / total * 100.0;
            pRato = (double)totalRato / total * 100.0;
            pSapo = (double)totalSapo / total * 100.0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelho);
            Console.WriteLine("Total de Ratos: " + totalRato);
            Console.WriteLine("Total de Sapos: " + totalSapo);

            Console.WriteLine("Percentual de coelhos: " + pCoelho.ToString("F2", CI));
            Console.WriteLine("Percentual de ratos: " + pRato.ToString("F2", CI));
            Console.WriteLine("Percentual de sapos: " + pSapo.ToString("F2", CI));

        }
    }
}
