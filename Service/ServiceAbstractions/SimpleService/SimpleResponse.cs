using System;
using System.Runtime.Serialization;

namespace ServiceAbstractions.SimpleService
{
    [DataContract]
    public class SimpleResponse 
    {
        [DataMember]
        public string Request { get; set; }

        [DataMember]
        public DateTime ResponseTime { get; set; }
    }
}