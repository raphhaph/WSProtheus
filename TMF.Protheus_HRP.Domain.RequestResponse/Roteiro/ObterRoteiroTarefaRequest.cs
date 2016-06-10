using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class ObterRoteiroTarefaRequest : RequestBase
    {
        [DataMember]
        public int IdRoteiroTarefa { get; set; }
    }
}
