using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAbstractions.SimpleService;

namespace SimpleService
{
    public class SimpleService : ISimpleService
    {
        public void SinkRequest(string request)
        {
            Console.WriteLine($"SinkRequest called with parameter: {request}");
        }

        public SimpleResponse GetSimpleResponse(string request)
        {
            var result = new SimpleResponse {Request = request, ResponseTime = DateTime.Now};

            Console.WriteLine($"GetSimpleResponse called with parameter: {request}, return value: {result.ResponseTime}");
            return result;
        }
    }
}
