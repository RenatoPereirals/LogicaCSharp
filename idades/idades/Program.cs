using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idades {
    internal class Program {
        static void Main(string[] args) {

            String nome1, nome2;
            int idade1, idade2;
            double media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (Double) (idade1 + idade2) / 2;

            Console.WriteLine();
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CI) + " anos");
        }
    }
}
