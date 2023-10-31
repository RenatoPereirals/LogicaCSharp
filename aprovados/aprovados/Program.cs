using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace aprovados {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos alunos serao digitados? ");
            int n = int.Parse(Console.ReadLine());

            String[] nome = new String[n];
            double[] nota1 = new double[n];
            double[] nota2 = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite nome, primeira nota e seguda nota do " + (i + 1) + "o aluno ");
                nome[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                nota2[i] = double.Parse(Console.ReadLine(), CI);
            }

            double[] soma = new double[n];
            double[] media = new double[n];

            for (int i = 0;i < n; i++) {
                soma[i] = nota1[i] + nota2[i];
                media[i] = soma[i] / 2.0;
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i <= n; i++) {
                if (media[i] >= 6) {
                    Console.WriteLine(nome[i]);
                }
            }

        }
    }
}
