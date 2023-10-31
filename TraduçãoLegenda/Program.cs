using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program {
    static async Task Main(string[] args) {
        string apiKey = "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";
        string sourceDirectory = @"C:\Users\devad\Desktop\Curso_edx-Harvard\legendas_tokenizados"; // Diretório com os arquivos de legendas tokenizados
        string targetLanguage = "pt";

        if (!Directory.Exists(sourceDirectory)) {
            Console.WriteLine("Diretório de origem não encontrado!");
            return;
        }

        string[] subtitleFiles = Directory.GetFiles(sourceDirectory, "*.txt");

        using (HttpClient client = new HttpClient()) {
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            foreach (string subtitleFile in subtitleFiles) {
                string subtitles = File.ReadAllText(subtitleFile);
                string translateSubtitles = await TranslateTextAsync(client, subtitles, targetLanguage);

                string outputFileName = Path.GetFileNameWithoutExtension(subtitleFile) + "_translated.txt";
                string outputFilePath = Path.Combine(sourceDirectory, outputFileName);

                File.WriteAllText(outputFilePath, translateSubtitles);

                Console.WriteLine($"Arquivo {outputFileName} traduzido e salvo.");
            }
        }

        Console.WriteLine("Tradução de legendas concluída!");
    }

    static async Task<string> TranslateTextAsync(HttpClient client, string text, string targetLanguage) {
        string apiURL = "https://api.openai.com/v1/engines/davinci/completions";
        string inputPrompt = $"Traduza o seguinte texto para {targetLanguage}:\n{text}";
        string requestBody = JsonConvert.SerializeObject(new {
            prompt = inputPrompt,
            temperature = 0.7,
            max_tokens = 2000
        });

        var content = new StringContent(requestBody, Encoding.UTF8, "application/json");
        var response = await client.PostAsync(apiURL, content);

        string responseContent = await response.Content.ReadAsStringAsync();
        return responseContent;
    }
}
