using System.Collections.Generic;
using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class ObterRoteiroResponse : ResponseBase
    {
        [DataMember]
        public List<Models.Roteiro> ListaRoteiros { get; set; }
    }
}
