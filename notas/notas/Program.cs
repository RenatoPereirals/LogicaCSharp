using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas {
    internal class Program {
        static void Main(string[] args) {

            double nota1, nota2;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            double soma = nota1 + nota2;                  

            Console.WriteLine("nota final = " + soma.ToString("F1", CI));

            if (soma < 60) {
                Console.WriteLine("REPROVADO");
            }            
        }
    }
}
