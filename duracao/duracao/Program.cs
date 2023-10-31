using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duracao {
    internal class Program {
        static void Main(string[] args) {

            int duracao, hora, minuto, segundo;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a duração em segundos: ");
            duracao = int.Parse(Console.ReadLine());

            hora = duracao / 3600;
            minuto = duracao % 3600 / 60;
            segundo = duracao % 3600 % 60;

            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
        }
    }
}
