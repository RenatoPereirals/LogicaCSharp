using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace matriz_geral {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual a ordeam da matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n,n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i,j] = double.Parse(Console.ReadLine(), CI);
                }
            }

            double somaPositivos = 0;
            
            for (int i = 0;i < n; i++) {
                for(int j = 0;j < n; j++) {
                    if (mat[i, j] > 0) {
                        somaPositivos += mat[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("SOMA DOS  POSITIVOS: " + somaPositivos.ToString("F1", CI));

            Console.WriteLine();
            Console.Write("Escolha uma linha: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < n ; j++) {
                Console.Write(mat[linha,j].ToString("F1", CI) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Escolha uma coluna: ");
            int coluna = int.Parse(Console.ReadLine());

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, coluna].ToString("F1", CI) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");
            for(int i = 0; i < n; i++) {
                Console.Write(mat[i,i].ToString("F1", CI) + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] < 0) {
                        mat[i,j] = Math.Pow(mat[i,j], 2);
                    }
                    Console.Write(mat[i,j].ToString("F1", CI) + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
