using System;
using System.Globalization;
using System.IO;

namespace troco_verificado {
    internal class Program {
        static void Main(string[] args) {

            int qtd;
            double preco, troco, dinheiro;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Preco unitario: ");
            preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            troco = dinheiro - qtd * preco;

            if (troco < 0) {
                troco = Math.Abs(troco);
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + troco.ToString("f2", CI) + " REAIS");
            } else {              
                Console.WriteLine("Troco = " + troco.ToString("f2", CI));
            }

           


        }
    }
}
