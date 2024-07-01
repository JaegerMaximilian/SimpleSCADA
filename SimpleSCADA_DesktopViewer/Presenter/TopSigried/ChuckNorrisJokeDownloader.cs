using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleSCADA_DesktopViewer.Presenter.TopSigried
{
    public class ChuckNorrisJokeDownloader
    {
        public static async Task<string> GetJsonString()
        {
            // Request API
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://matchilling-chuck-norris-jokes-v1.p.rapidapi.com/jokes/random"),
                Headers =
                {
                    { "accept", "application/json" },
                    { "X-RapidAPI-Key", "0deff8ac7dmsh4e5698cdf37b023p144eb4jsn10ab8c50e715" },
                    { "X-RapidAPI-Host", "matchilling-chuck-norris-jokes-v1.p.rapidapi.com" },
                },
            };

            Joke joke = new Joke();

            // Download Json
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                // Convert Json to Joke
                joke = JsonConvert.DeserializeObject<Joke>(body);
            }

            return joke.value;
        }
    }
}
