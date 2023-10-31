using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace quadrante {
    internal class Program {
        static void Main(string[] args) {

            double x, y;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite os valores de X e Y:");
            x = double.Parse(Console.ReadLine(), CI);
            y = double.Parse(Console.ReadLine(), CI);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Q1");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Q2");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Q3");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("Q4");
                }
                Console.WriteLine("Digite os valores de X e Y:");
                x = double.Parse(Console.ReadLine(), CI);
                y = double.Parse(Console.ReadLine(), CI);
            }
        }
    }
}
