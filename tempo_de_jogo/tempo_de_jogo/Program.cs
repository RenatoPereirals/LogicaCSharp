using System;
using System.Globalization;

namespace tempo_de_jogo {
    internal class Program {
        static void Main(string[] args) {

            int horaInicial, horaFinal, duracao;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            horaFinal = int.Parse(Console.ReadLine());
           
            if (horaInicial == horaFinal) {
                duracao = 24;
            }
            else if (horaInicial > horaFinal) {
                duracao = horaFinal - horaInicial + 24;
            }
            else {
                duracao = horaFinal - horaInicial;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
