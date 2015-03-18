using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CompatibleSoftware.Poker.Console
{
    public static class ApiCaller<T>
    {
        private const string BASE_URL = "http://localhost:80/PokerAPI/";

        public static async Task<T> PostNew(string url, T postedObject)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(postedObject);

            var returnedObject = default(T);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    var str = await response.Content.ReadAsStringAsync();
                    returnedObject = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(str);
                }
            }

            return returnedObject;
        }
    }
}
