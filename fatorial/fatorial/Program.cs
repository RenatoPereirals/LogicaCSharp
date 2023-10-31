using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial {
    internal class Program {
        static void Main(string[] args) {

            int n, fatorial;

            Console.Write("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            fatorial = 1;

            for (int i = 1; i <= n; i++) {
                fatorial = fatorial * i;
             }

            Console.WriteLine("FATORIAL = " + fatorial);
        }
    }
}
