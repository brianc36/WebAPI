using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if  (args.Length > 0)
            {
                Task<string> callTask = Task.Run(() => CallWebApiAsync(args[0]));

                callTask.Wait();

                var response = callTask.Result;
                Console.WriteLine(response);

                Console.WriteLine("");
                Console.Write("Press enter to continue..");
                var readLine = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No URL passed as argument.");
                Console.WriteLine("");
                Console.Write("Press enter to continue..");
            }
           
            
        }
        public static async Task<string> CallWebApiAsync(string webApiUrl)
        {
            string response = string.Empty;

            try
            {
                var client = new HttpClient();
                Uri requestURI = new Uri(webApiUrl);
                response = await client.GetStringAsync(webApiUrl);

            }
            catch (Exception)
            {
                Console.WriteLine("Oh snap!!!");

            }

            return response;
        }

    }
}
