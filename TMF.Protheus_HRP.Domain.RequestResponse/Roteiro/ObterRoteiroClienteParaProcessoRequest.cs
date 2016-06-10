using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class ObterRoteiroClienteParaProcessoRequest : RequestBase
    {
        [DataMember]
        public int IdFilialMasterData { get; set; }
        [DataMember]
        public int IdAssunto { get; set; }
        [DataMember]
        public int IdTipoDocumento { get; set; }
    }
}
