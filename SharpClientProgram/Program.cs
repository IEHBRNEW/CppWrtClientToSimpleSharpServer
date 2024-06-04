using SharpClientLib;

class Program
{
    static async Task Main()
    {
        string url = "http://localhost:8080/";
        try
        {
            string response = SharpClient.GetString(url);
            Console.WriteLine(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}