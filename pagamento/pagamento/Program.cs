using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pagamento {
    internal class Program {
        static void Main(string[] args) {

            String nome;
            int hora;
            double salario, valorHora;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            hora = int.Parse(Console.ReadLine());

            salario = valorHora * hora;

            Console.WriteLine("O pagamento para " + nome + " deve ser " + salario.ToString("F2", CI));

        }
    }
}
