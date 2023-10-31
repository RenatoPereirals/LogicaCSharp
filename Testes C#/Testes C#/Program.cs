using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_C_ {
    internal class Program {
        static void Main(string[] args) {

            var names = new List<string> { "Ana", "Maria", "Paulo", "Joao" };
            foreach (var nemes in names) {
                Console.WriteLine($"Bom dia {nemes.ToLower()}!");
            }



        }
    }
}
