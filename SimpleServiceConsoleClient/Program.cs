using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleServiceConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var service = new SimpleServiceRef.SimpleServiceClient("BasicHttpBinding_ISimpleService"))
            {
                service.Open();
                service.SinkRequest("ConsoleClient calling SinkRequest");

                var response = service.GetSimpleResponse("ConsoleClient requesting SimpleResponse");
                Console.WriteLine($"Service response time: {response.ResponseTime}");
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
