using System;
using System.Globalization;

namespace terreno {
    internal class Program {
        static void Main(string[] args) {

            double largura, comprimeno, valor, area, preco;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a largura do terre: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terre: ");
            comprimeno = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do terreno: ");
            valor = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimeno;
            preco = valor * area;

            Console.WriteLine("AREA DO TERRENO = " + area.ToString("F2", CI));
            Console.WriteLine("VALOR DO TERRENO = " + preco.ToString("F2", CI));


        }
    }
}
