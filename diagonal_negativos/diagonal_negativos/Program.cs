using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal_negativos {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual a ordem da matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
           
            int conNegativos = 0;

            for (int i = 0;i < n; i++) {
                for(int j = 0;j < n; j++) {
                    if (mat[i,j] < 0) {
                        conNegativos++;
                    }
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + conNegativos);

        }
    }
}
