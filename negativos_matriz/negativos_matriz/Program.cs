using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativos_matriz {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantidade de linhas da matriz: ");
            int m =int.Parse(Console.ReadLine());
            Console.Write("Quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0;i < m; i++) {
                for (int j = 0;j < n; j++) {
                    if (mat[i,j] < 0) {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }
        }
    }
}
