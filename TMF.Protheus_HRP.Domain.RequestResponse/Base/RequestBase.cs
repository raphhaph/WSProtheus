using System;
using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Base
{
    [DataContract]
    public class RequestBase : RequestResponseBase
    {
        [DataMember]
        public String Locale { get; set; }
        [DataMember]
        public string Usuario { get; set; }

        [DataMember]
        public string Senha { get; set; }
    }
}
