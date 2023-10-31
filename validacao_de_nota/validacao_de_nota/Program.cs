using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace validacao_de_nota {
    internal class Program {
        static void Main(string[] args) {

            double nota1, nota2, media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);

            while (nota1 < 0 || nota1 > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota1 = double.Parse(Console.ReadLine(), CI);
            }

            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            while (nota2 < 0 || nota2 > 10) {
                Console.Write("Valor invalido! Tente novamente: ");
                nota2 = double.Parse(Console.ReadLine(), CI);
            }

            media = (nota1 + nota2) / 2.0;

            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
        }
    }
}
