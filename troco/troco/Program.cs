using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troco {
    internal class Program {
        static void Main(string[] args) {
            int qtd;
            double dinheiro, preco, troco;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Preco unitario: ");
            preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            troco = (double) dinheiro - preco * qtd;

            Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
        }
    }
}
