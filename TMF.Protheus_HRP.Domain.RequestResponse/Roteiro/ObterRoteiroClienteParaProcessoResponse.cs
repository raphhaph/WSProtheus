using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class ObterRoteiroClienteParaProcessoResponse : ResponseBase
    {
        [DataMember]
        public int IdRoteiroCliente { get; set; }
        [DataMember]
        public int IdRoteiro { get; set; }
        [DataMember]
        public int IdClienteMasterData { get; set; }
        [DataMember]
        public int IdEmpresaMasterData { get; set; }
    }
}
