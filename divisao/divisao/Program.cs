using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisao {
    internal class Program {
        static void Main(string[] args) {

            int n; 
            double numerador, denominador, resultado;

            CultureInfo CI = CultureInfo.InvariantCulture;  

            Console.Write("Quantos casos voce vai digitar: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                Console.Write("Entre com o numerador: ");
                numerador = int.Parse(Console.ReadLine(), CI);
                Console.Write("Entre com o denominador: ");
                denominador = int.Parse(Console.ReadLine(), CI);    

                if (denominador == 0) {
                    Console.WriteLine("Divisao impossivel.");
                } else {
                    resultado = numerador / denominador;
                    Console.WriteLine("DIVISAO = " + resultado.ToString("F2", CI));
                }
            }


        }
    }
}
