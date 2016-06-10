using System;
using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Roteiro
{
    [DataContract]
    public class ListarRoteiroTarefaResponse : ResponseBase
    {
        [DataMember]
        public int IdRoteiroTarefa { get; set; }
        [DataMember]
        public int IdRoteiro { get; set; }
        [DataMember]
        public int? IdArea { get; set; }
        [DataMember]
        public int IdTarefa { get; set; }
        [DataMember]
        public int SLAPadrao { get; set; }
        [DataMember]
        public int? IdEstagio { get; set; }
        [DataMember]
        public int? IdProximoRoteiroTarefaPadrao { get; set; }
        [DataMember]
        public int? IdRoteiroTarefaErro { get; set; }
        [DataMember]
        public string DescricaoEtapa { get; set; }
        [DataMember]
        public DateTime Atualizacao { get; set; }
        [DataMember]
        public int IdUsuarioAtualizacaoMasterData { get; set; }
        [DataMember]
        public bool IncioTarefaRoteiro { get; set; }
    }
}
