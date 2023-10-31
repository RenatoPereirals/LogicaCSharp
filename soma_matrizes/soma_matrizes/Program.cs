using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace soma_matrizes {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantas linhas vai ter cada matriz? ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];

            Console.WriteLine("Digite os elementos da matriz A: ");

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemeno [" + i + "," + j + "]: ");
                    A[i,j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] B = new int[m, n];

            Console.WriteLine("Digite os elementos da matriz B: ");

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemeno [" + i + "," + j + "]: ");
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] soma = new int[m, n];

            for(int i = 0;i < m; i++) {
                  for(int j = 0;j < n; j++) {
                    soma[i,j] = A[i,j] + B[i,j];
                }
            }

            Console.WriteLine("MATRIZ SOMA:");

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(soma[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
