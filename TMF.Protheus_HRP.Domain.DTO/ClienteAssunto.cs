using System;
using TMF.FollowME.Domain.DTO.Base;

namespace TMF.FollowME.Domain.DTO
{
    [Serializable]
    public class ClienteAssunto : Entity
    {
        public int IdClienteAssunto { get; set; }
        public int IdClienteMasterData { get; set; }
        public int IdEmpresaMasterData { get; set; }
        public int IdFilialMasterData { get; set; }
        public int SlaTotal { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int IdUsuarioMasterDataAtualizacao { get; set; }
        public int IdAssunto { get; set; }
    }
}
