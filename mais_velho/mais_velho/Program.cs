using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mais_velho {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantas pessoas voce vai digitar? ");
                int n = int.Parse(Console.ReadLine());

            String[] nome = new String[n];
            int[] idade = new int[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            int maisVelho = idade[0];
            String nomeMaisVelho = null;

            for (int i = 1; i < n; i++) {
                if (idade[i] > maisVelho) {
                    maisVelho = idade[i];
                    nomeMaisVelho = nome[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomeMaisVelho);

        }
    }
}
