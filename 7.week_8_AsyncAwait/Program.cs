using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _7.week_8_AsyncAwait
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            PerformOperation();

           string result = await FetchData();

           await Console.Out.WriteLineAsync(result);

        }

        static async Task<string> FetchData()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://url.com");

            return result;

        }

        static async Task PerformOperation()
        {

            await Task.Delay(3000);

            await Console.Out.WriteLineAsync("ASYNC OOP");

        }




    }
}
