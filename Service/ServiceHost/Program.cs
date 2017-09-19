using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
//using System.ServiceModel.Channels;
//using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using ServiceAbstractions.SimpleService;

namespace ServiceHost
{
    class Program
    {
        private static System.ServiceModel.ServiceHost _serviceHost;

        static void Main(string[] args)
        {
            Console.WriteLine("Hosting DemoServer...");

            HostSimpleService(9001); 

            string resp = "";
            while (resp.ToLower() != "exit")
            {
                Console.WriteLine("");
                Console.WriteLine("Enter 'Exit' to exit...");

                resp = Console.ReadLine();
            }
        }

        private static void HostSimpleService(int basePort)
        {
            _serviceHost?.Close();

            // Remember: in Dos prompt (Admin rights): netsh http add urlacl url=http://+:{basePort}/SimpleService user=Everyone
            var httpEndpoint = $"http://localhost:{basePort}/SimpleService";
            var tcpEndpoint = $"net.tcp://localhost:{basePort+1}/SimpleService";

            Uri[] baseAddresses = { new Uri(httpEndpoint), new Uri(tcpEndpoint) };
            _serviceHost = new System.ServiceModel.ServiceHost(typeof(SimpleService.SimpleService), baseAddresses);

            var metadataBehavior = new ServiceMetadataBehavior();
            _serviceHost.Description.Behaviors.Add(metadataBehavior);

            _serviceHost.AddServiceEndpoint(typeof(ISimpleService), WcfBindings.GetBasicHttpBinding(), httpEndpoint);
            _serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            _serviceHost.AddServiceEndpoint(typeof(ISimpleService), WcfBindings.GetNetTcpBinding(), tcpEndpoint);
            //_serviceHost.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

            _serviceHost.Open();
        }
    }
}
