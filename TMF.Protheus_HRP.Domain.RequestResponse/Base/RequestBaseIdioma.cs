using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Base
{
    [DataContract]
    public class RequestBaseIdioma : RequestBase
    {
        [DataMember]
        public int IdIdioma { get; set; }
    }
}
