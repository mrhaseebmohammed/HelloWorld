using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessHelloWorld().Wait();
        }

        private static async Task ProcessHelloWorld()
        {
            // TODO Create configuration to set base culture.
            // TODO Learn future business requirements. Will this require user input to select a word?

            // TODO Refactor below to create a re-usable function to process any word in dictionary.
            var uri = "http://localhost:5000/api/Translate?word=helloWorld&culture=en-US";

            var client = new HttpClient();

            var stringTask = client.GetStringAsync(uri);

            var response = await stringTask;

            Console.WriteLine(response);
        }
    }
}
