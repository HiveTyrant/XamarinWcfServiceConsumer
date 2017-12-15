using System;
using System.ServiceModel;

namespace XamarinClient.Helpers
{
    public class WcfBindings
    {
        /// <summary>
        /// Build a WSBasicHttpBinding, which is for Basic web service communication. Exposes WCF services 
        /// as legacy ASMX web services. Used for interoperability. No security by default.
        /// </summary>
        /// <returns></returns>
        public static BasicHttpBinding GetBasicHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.SendTimeout = new TimeSpan(0, 4, 0, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 4, 0, 0);
            binding.OpenTimeout = new TimeSpan(0, 0, 1, 0);
            binding.CloseTimeout = new TimeSpan(0, 0, 10, 0);
            binding.Security.Mode = BasicHttpSecurityMode.None;
            // binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            binding.MaxReceivedMessageSize = 2147483647;
            // binding.MaxBufferPoolSize = 0;
            // binding.MessageEncoding = WSMessageEncoding.Text;
            //binding.ClientBaseAddress = new Uri("http://localhost:58000");
            //binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            //binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
            //binding.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
            //binding.ReaderQuotas.MaxDepth = 32;
            //binding.ReaderQuotas.MaxNameTableCharCount = 16384;
            return binding;
        }
    }
}