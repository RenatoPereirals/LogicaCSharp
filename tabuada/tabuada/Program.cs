using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada {
    internal class Program {
        static void Main(string[] args) {

            int x;

            Console.Write("Deseja tabuada para qual valor: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(x + " X " + i + " = " + x * i);
            }

        }
    }
}
