using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class BuscarRoteiroTarefaRequest : RequestBase
    {
        [DataMember]
        public int IdRoteiro { get; set; }
    }
}
