
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _7.week_8_TAP
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("Yumurta haşlanıyor");

            await BoilEggAsync().ConfigureAwait(task =>
            {
                if (task.IsCompletedSuccessfuly)
                {
                    Console.WriteLine("Hatasız tamamlandı");
                }
                else if(task.isFaulted)
                {
                    Console.WriteLine($"Görev hata aldı. hata {task.Exception.GetBaseException().Message}");
                }
                else
                {

                }

            });
            await Console.Out.WriteLineAsync("Yumurta haşlandı");

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            Task<String> fetchTask = FetchDataAsync(cancellationTokenSource.Token);

            await Task.Delay(1000);

            cancellationTokenSource.Cancel();

            try
            {
                string content2 = await fetchTask;


            }
            catch (OperationCanceledException)
            {

                await Console.Out.WriteLineAsync("işlem iptal edildi");
            }

            string content = await FetchDataAsync();
            await Console.Out.WriteLineAsync(content);

        }

        static async Task BoilEggAsync()
        {
            await Task.Delay(2000);
            await Console.Out.WriteLineAsync("Yumurta Haşlama Süreci tamamlandı");
        }


        static async Task<string> FetchDataAsync(CancellationToken token)
        {
            HttpClient client = new HttpClient();

            string result = await client.GetStringAsync("http://api.com", token);


            return result;

        }

    }
}
