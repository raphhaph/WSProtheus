using System;
using TMF.FollowME.Domain.DTO.Base;
using TMF.FollowME.Domain.DTO.Enum;

namespace TMF.FollowME.Domain.DTO.Roteiro
{
    public class RoteiroTarefa : Entity
    {
        public int IdRoteiroTarefa { get; set; }
        public int IdRoteiro { get; set; }
        public int IdArea { get; set; }
        public int IdTarefa { get; set; }
        public int SLAPadrao { get; set; }
        public int IdEstagio { get; set; }
        public int? IdProximoRoteiroTarefaPadrao { get; set; }
        public int? IdRoteiroTarefaErro { get; set; }
        public string DescricaoEtapa { get; set; }
        public DateTime Atualizacao { get; set; }
        public int IdUsuarioAtualizacao { get; set; }
        public StatusProcessoTarefa StepTarefaRoteiro { get; set; }

    }
}
