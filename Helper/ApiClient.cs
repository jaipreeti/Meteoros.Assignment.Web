using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace Meteoros.Assignment.Web.Helper
{
    public static class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PostAsync(string url, string data)
        {
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> PutAsync(string url, string data)
        {
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public static async Task<string> DeleteAsync(string url)
        {
            HttpResponseMessage response = await client.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
