using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senha_fixa {
    internal class Program {
        static void Main(string[] args) {

            int senha;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a senha: ");
            senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 2002) {
                Console.Write("Senha invalida! Tente novamente: ");
                senha = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");

        }
    }
}
