using System;
using TMF.FollowME.Domain.DTO.Base;

namespace TMF.FollowME.Domain.DTO.Roteiro
{
    public class RoteiroCliente : Entity
    {
        public int IdRoteiroCliente { get; set; }
        public int IdRoteiro { get; set; }
        public int IdCLienteMasterData { get; set; }
        public int IdEmpresaMasterData { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdAssunto { get; set; }
        public int? IdFilialMasterData { get; set; }
        public int SlaTotal { get; set; }
        public DateTime Atualizacao { get; set; }
        public int IdUsuarioAtualizacaoMasterData { get; set; }
    }
}
