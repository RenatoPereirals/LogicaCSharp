using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combustivel {
    internal class Program {
        static void Main(string[] args) {

            int codigo, contAlcool, contGasolina, contDisel;

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());

            contAlcool = 0;
            contGasolina = 0;
            contDisel = 0; 

            while (codigo != 4) {
                switch (codigo) {

                    case 1: contAlcool++; break; 
                    case 2: contGasolina++; break; 
                    case 3: contDisel++; break;                    
                }
                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + contAlcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Disel: " + contDisel);

        }
    }
}
