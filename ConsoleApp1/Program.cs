using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await SendPostRequest();
        Console.ReadKey();
    }

    static async Task SendPostRequest()
    {
        await StartGame();
        await Login();
        await Sum();
        await Reward();
    }
    public static async Task StartGame()
    {
        string url = "https://antamacoding.com/Home/welcoming";

        using (HttpClient client = new HttpClient())
        {
            /*var content = new FormUrlEncodedContent(data);
            var response = await client.PostAsync(url,data);*/
            var response = await client.GetAsync(url);

            Console.WriteLine($"Status Code: {response.StatusCode}");
            Console.WriteLine($"Response Content: {await response.Content.ReadAsStringAsync()}");
        }
    }
    public static async Task Login()
    {
        string url = "https://antamacoding.com/Home/login";

        var data = new Dictionary<string, string>
        {
            { "name", "User" },
            { "PaSsword", "123"}
        };

        using (HttpClient client = new HttpClient())
        {
            var content = new FormUrlEncodedContent(data);
            var response = await client.PostAsync(url, content);
            //var response = await client.GetAsync(url);

            Console.WriteLine($"Status Code: {response.StatusCode}");
            Console.WriteLine($"Response Content: {await response.Content.ReadAsStringAsync()}");
        }
    }
    public static async Task Sum()
    {
        string url = "https://antamacoding.com/Home/sum";

        var data = new Dictionary<string, string>
        {
            { "a", "1" },
            { "b", "2"}
        };

        using (HttpClient client = new HttpClient())
        {
            var content = new FormUrlEncodedContent(data);
            var response = await client.PostAsync(url, content);
            //var response = await client.GetAsync(url);

            Console.WriteLine($"Status Code: {response.StatusCode}");
            Console.WriteLine($"Response Content: {await response.Content.ReadAsStringAsync()}");
        }
    }
    public static async Task Reward()
    {
        string url = "https://antamacoding.com/Home/pythonsucks";
        using (HttpClient client = new HttpClient())
        {
            /*var content = new FormUrlEncodedContent(data);
            var response = await client.PostAsync(url,data);*/
            var response = await client.GetAsync(url);

            Console.WriteLine($"Status Code: {response.StatusCode}");
            Console.WriteLine($"Response Content: {await response.Content.ReadAsStringAsync()}");
        }
    }
}