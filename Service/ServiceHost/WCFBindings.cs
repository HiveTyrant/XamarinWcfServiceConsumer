using System;
using System.ServiceModel;

namespace ServiceHost
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
            binding.SendTimeout = new TimeSpan(0, 0, 0, 10);
            binding.ReceiveTimeout = new TimeSpan(0, 0, 0, 10);
            binding.OpenTimeout = new TimeSpan(0, 0, 0, 10);
            binding.CloseTimeout = new TimeSpan(0, 0, 0, 10);
            binding.Security.Mode = BasicHttpSecurityMode.None;
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferPoolSize = 0;
            binding.MessageEncoding = WSMessageEncoding.Text;
            //binding.ClientBaseAddress = new Uri("http://localhost:58000");
            //binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            //binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
            //binding.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
            //binding.ReaderQuotas.MaxDepth = 32;
            //binding.ReaderQuotas.MaxNameTableCharCount = 16384;
            return binding;
        }

        /// <summary>
        /// Build a NetTcpBinding
        /// </summary>
        /// <returns></returns>
        public static NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding binding = new NetTcpBinding();
            binding.TransactionFlow = true;
            binding.SendTimeout = new TimeSpan(0, 4, 0, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 4, 0, 0);
            binding.OpenTimeout = new TimeSpan(0, 0, 1, 0);
            binding.CloseTimeout = new TimeSpan(0, 0, 10, 0);
            binding.Security.Mode = SecurityMode.None;
            binding.Security.Message.ClientCredentialType = MessageCredentialType.None;
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;//0;
            binding.MaxBufferSize = 2147483647;//0;
            binding.MaxConnections = 50; //When fetching base data as contacts, contactvariants and types like price types etc. we exceed 20-25 connections. Default is 10.
            // binding.MaxConnections = 2147483647;//0;  // NIP, Removed again, as this takes up a LOT of memory when the Client connects (Out-of-memory exception)
            binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            binding.ReaderQuotas.MaxArrayLength = int.MaxValue;
            binding.ReaderQuotas.MaxBytesPerRead = int.MaxValue;
            binding.ReaderQuotas.MaxDepth = int.MaxValue;
            binding.ReaderQuotas.MaxNameTableCharCount = int.MaxValue;

            // NOTE: Remember to change your devenv.exe.config in C:\Program Files\Microsoft Visual Studio 10.0\Common7\IDE with metadata from 
            // NOTE: "C:\Project\PlusFlex\Trunk\Documentation\Tips and tricks\Opdatering af service reference - maximum nametable character .docx"

            return binding;
        }
    }
}