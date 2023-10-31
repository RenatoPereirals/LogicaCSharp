using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_pessoas {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;  

            Console.Write("Quantas pessoas voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            char[] genero = new char[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                genero[i] = char.Parse(Console.ReadLine());
            }

            double menorAltura = altura[0];
            double maiorAltura = altura[0];

            for (int i = 1; i < n; i++) {
                if (altura[i] < menorAltura) {
                    menorAltura = altura[i];
                } else if (altura[i]  > maiorAltura) {
                    maiorAltura = altura[i];
                }
            }

            int contMulheres = 0;
            double somaMulheres = 0;

            for (int i = 0;i < n;i++) {
                if (genero[i] == 'F') {
                    contMulheres++;
                    somaMulheres += altura[i];
                }
            }

            double mediaMulheres = somaMulheres / contMulheres;

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CI));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CI));
            Console.WriteLine("Media das alturas das mulheres = " + mediaMulheres.ToString("F2", CI));
            Console.WriteLine("Numeros de homens = " + (n - contMulheres));
        }
    }
}
