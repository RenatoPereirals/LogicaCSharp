using System;
using System.Threading.Tasks;

class Program {
    static async Task Main(string[] args) {
        int maxRequestsPerMinute = 3;
        TimeSpan delayBetweenRequests = TimeSpan.FromMinutes(1.0 / maxRequestsPerMinute);

        for (int i = 0; i < 10; i++) // Fazer 10 solicitações como exemplo
        {
            await MakeRequest();
            await Task.Delay(delayBetweenRequests);
        }
    }

    static async Task MakeRequest() {
        // Simulação de uma solicitação
        Console.WriteLine("Fazendo uma solicitação...");
        await Task.Delay(1000); // Simulação de uma espera de 1 segundo
        Console.WriteLine("Solicitação concluída.");
    }
}
