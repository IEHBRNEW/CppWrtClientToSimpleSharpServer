namespace SharpClientLib
{
    public sealed class SharpClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static string GetString(string url)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();

                string responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: " + e.Message);
                throw;
            }
        }
    }
}
