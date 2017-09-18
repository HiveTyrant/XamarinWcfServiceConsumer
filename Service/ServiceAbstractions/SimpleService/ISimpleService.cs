using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAbstractions.SimpleService
{
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        void SinkRequest(string request);

        [OperationContract]
        SimpleResponse GetSimpleResponse(string request);
    }
}
