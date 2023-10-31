using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_idades {
    internal class Program {
        static void Main(string[] args) {

            int idade, cont, soma;
            double media;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as idades:");
            idade = int.Parse(Console.ReadLine());

            soma = 0;
            cont = 0;

            if (idade < 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {

                while (idade >= 0) {
                    soma += idade;
                    cont++;                  
                    idade = int.Parse(Console.ReadLine());
                }

                media = (double)soma / cont;

                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }           

        }
    }
}
