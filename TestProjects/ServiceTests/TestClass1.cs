using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServiceHost;

namespace ServiceTests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public async Task CallSimpleServiceHTTP_Test()
        {
            // Remember: in Dos prompt (Admin rights): netsh http add urlacl url=http://+:{basePort}/SimpleService user=Everyone
            var service = new SimpleServiceRef.SimpleServiceClient(WcfBindings.GetBasicHttpBinding(), new EndpointAddress("http://localhost:9001/SimpleService"));
            await service.SinkRequestAsync("Http - sinkrequest");
            var response = await service.GetSimpleResponseAsync("Http - GetSimpleResponse");
        }

        [Test]
        public async Task CallSimpleServiceNetTCP_Test()
        {
            // Remember: in Dos prompt (Admin rights): netsh http add urlacl url=http://+:{basePort}/SimpleService user=Everyone
            var service = new SimpleServiceRef.SimpleServiceClient(WcfBindings.GetNetTcpBinding(), new EndpointAddress("net.tcp://localhost:9002/SimpleService"));
            await service.SinkRequestAsync("NetTcp - sinkrequest");
            var response = await service.GetSimpleResponseAsync("NetTcp - GetSimpleResponse");
        }

    }
}
