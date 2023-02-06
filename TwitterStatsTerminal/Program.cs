using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;

namespace TwitterStatsTerminal
{
    internal class Program
    {

        //public static async Task Main(string[] args)
        //{
        //    // your asynchronous code here

        //    Console.WriteLine("qrewqwer");
        //    await Task.Delay(6000);
        //    Console.WriteLine("asdfasdfasdf");
        //}

        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var token = "AAA...wlf";   // placeholder for token
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.twitter.com/2/tweets/sample/stream?tweet.fields=context_annotations,lang");
            using (var stream = await client.GetStreamAsync(request.RequestUri))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = await reader.ReadLineAsync();
                    if (!string.IsNullOrEmpty(line)) 
                    {
                        Console.WriteLine(line);
                        Console.WriteLine("\n\n\n\n");
                    }
                }
            }

        }
    }
}