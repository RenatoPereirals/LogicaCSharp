using System;
using System.Globalization;

namespace aumento {
    internal class Program {
        static void Main(string[] args) {

            double salario, novoSalario, aumento, porcetagem;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), CI);
            
            if (salario <= 1000) {
                novoSalario = salario * 1.2;
            } else if (salario <= 3000) {
                novoSalario = salario * 1.15;
            } else if (salario <= 8000) {
                novoSalario = salario * 1.1;
            } else {
                novoSalario = salario * 1.05;
            }

            aumento = novoSalario - salario;
            porcetagem = aumento / salario * 100.0;

            Console.WriteLine("Novo salario = R$ " + novoSalario.ToString("F2", CI));
            Console.WriteLine("Aumento = R$ " + aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + porcetagem.ToString("F2", CI) + " %");

        }
    }
}
