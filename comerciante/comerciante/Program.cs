using System;
using System.Globalization;

namespace comerciante {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Serao digitados dados de quantos produtos? ");
            int n = int.Parse(Console.ReadLine());

            String[] produto = new String[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Produto " + (i + 1) + ": ");
                Console.Write("Nome: ");
                produto[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                precoCompra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                precoVenda[i] = double.Parse(Console.ReadLine(), CI);
            }

            int abaixo = 0, entre = 0,  acima = 0;
            double[] porcentagem = new double[n];

            for(int i = 0;i < n;i++) {

                porcentagem[i] = (precoVenda[i] - precoCompra[i]) / precoCompra[i] * 100.0;

                if (porcentagem[i] < 10.0) {
                    abaixo++;
                } else if (porcentagem[i] <= 20.0) {
                    entre++;
                } else {
                    acima++;
                }
            }

            double totalCompra = 0;
            double totalVenda = 0;
            
            for(int i = 0; i < n;i++) {
                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
            }     
                        
            Console.WriteLine();
            Console.WriteLine("RELATORIO");
            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre de 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);

            Console.WriteLine("Valor toral de compra: " + totalCompra.ToString("F2", CI));
            Console.WriteLine("Valor toral de venda: " + totalVenda.ToString("F2", CI));
            Console.WriteLine("Lucro total: " + (totalVenda - totalCompra).ToString("F2", CI));

        }
    }
}
