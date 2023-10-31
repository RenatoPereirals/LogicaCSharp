using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura {
    internal class Program {
        static void Main(string[] args) {

            double fahrenheit, celsius, temperatura;
            char escala;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Voce vai digitar em qual escla (F/C): ");
            escala = char.Parse(Console.ReadLine());
            Console.Write("Digite o valor da temperatura: ");
            temperatura = double.Parse(Console.ReadLine(), CI);   

            if (escala == 'F') {
                celsius = (double) 5 / 9 * (temperatura - 32);
                Console.WriteLine("Temperatura equivalente em Celsius: " + celsius.ToString("f2", CI));

            } else {
                fahrenheit = (double) 9 * temperatura / 5 + 32;
                Console.WriteLine("Temperatura equivalente em Fahrenheit: " + fahrenheit.ToString("f2", CI));
            }
        }
    }
}
