using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_linhas {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;  

            Console.Write("Quantidade de linhas  da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat1 = new double[m, n];
            double[,] mat2 = new double[m, n];

            for (int i = 0; i < m; i++) {
                Console.WriteLine("Digite os elementos da " + (i + 1) + "a linha");
                for (int j = 0; j < n; j++) {
                    mat1[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            double[] soma = new double[m];

            for (int i = 0;i < m; i++) {
                double somaLinha = 0;
                for (int j = 0;j < n; j++) {
                    somaLinha += mat1[i, j];
                }
                soma[i] = somaLinha;
            }

            Console.WriteLine("VETOR GERADO: ");
            for(int i = 0; i < m; i++) {
                Console.WriteLine(soma[i].ToString("F1", CI));
            }

        }
    }
}
