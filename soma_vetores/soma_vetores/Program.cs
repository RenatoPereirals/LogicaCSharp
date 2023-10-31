using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_vetores {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quanto elementod vai ter cada vetor? ");
            int n = int.Parse(Console.ReadLine());

            int[] A = new int[n];
            int[] B = new int[n];

            Console.WriteLine("Digite os valores de A");
            for (int i = 0; i < n; i++) {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite os valores de B");
            for (int i = 0; i < n; i++) {
                B[i] = int.Parse(Console.ReadLine());
            }

            int[] C = new int[n];

            Console.WriteLine("VETOR RESULTANTE:");
            for(int i = 0;i < n; i++) {
                C[i] = A[i] + B[i];
                Console.WriteLine(C[i]);
            }

        }
    }
}
