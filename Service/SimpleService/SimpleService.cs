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
            // Do absolutely nothing with request
        }

        public SimpleResponse GetSimpleResponse(string request)
        {
            return new SimpleResponse {Request = request, ResponseTime = DateTime.Now};
        }
    }
}
