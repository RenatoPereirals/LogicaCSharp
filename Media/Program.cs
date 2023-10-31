using System;

class Program {
    static void Main() {
        try {
            int n;

            Console.WriteLine("Digite a quantidade de notas a serem calculadas: ");

            if (!int.TryParse(Console.ReadLine(), out n)) {
                throw new ArgumentException("Quantidade de notas inválida. Digite um número válido.");
            }

            float[] notas = new float[(int)n];

            Console.WriteLine("Digite as notas:");

            for (int i = 0; i < n; i++) {
                if (!float.TryParse(Console.ReadLine(), out float nota)) {
                    throw new ArgumentException("Nota inválida. Por favor, insira um número válido.");
                }

                notas[i] = nota;
            }

            float soma = 0;

            foreach (float nota in notas) {
                soma += nota;
            }

            float media = soma / n;

            Console.Write($" Sua média é: {media}. Você está ");

            if (media >= 7) {
                Console.WriteLine("aprovado :)");
            }
            else {
                Console.WriteLine("reprovado :(");
            }
        }
        catch (Exception ex) {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
