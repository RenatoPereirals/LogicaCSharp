using System;
using System.Globalization;

namespace lanchonete {
    internal class Program {
        static void Main(string[] args) {

            int qtd;
            int codigo;
            double valor, total;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Codigo do produto comprado: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            qtd = int.Parse(Console.ReadLine());

            valor = 0;

            switch (codigo) {
                case 1: valor = 5.00; break;
                case 2: valor = 3.50; break;
                case 3: valor = 4.80; break;
                case 4: valor = 8.90; break;
                case 5: valor = 7.32; break;
            }            

            total = valor * qtd;

            Console.WriteLine("Valor a pagar = R$ " + total.ToString("f2", CI));

        }
    }
}
