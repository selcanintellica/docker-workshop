using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static readonly HttpClient client = new HttpClient();
    private static readonly string apiUrl = Environment.GetEnvironmentVariable("API_URL") ?? "https://ornekapi.com/veri";
    private static readonly int interval = int.TryParse(Environment.GetEnvironmentVariable("INTERVAL"), out int value) ? value : 600;

    static async Task Main()
    {
        while (true)
        {
            await client.GetAsync(apiUrl);
            Thread.Sleep(interval);
        }
    }
}
