using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class ObterRoteiroRequest : RequestBase
    {
        [DataMember]
        public int IdRoteiro { get; set; }
    }
}
