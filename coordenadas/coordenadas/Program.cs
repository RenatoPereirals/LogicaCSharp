using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coordenadas {
    internal class Program {
        static void Main(string[] args) {

            double x, y;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor de X: ");
            x = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor de Y: ");
            y = double.Parse(Console.ReadLine(), CI);

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else {
                if (x == 0) {
                    Console.WriteLine("Eixo Y");
                }
                else if (y == 0) {
                    Console.WriteLine("Eixo X");
                }
                else {
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


                }
            }
        }
    }
}
