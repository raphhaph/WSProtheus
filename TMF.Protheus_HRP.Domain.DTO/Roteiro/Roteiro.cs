using System;

namespace TMF.FollowME.Domain.DTO.Roteiro
{
    public class Roteiro
    {
        public int IdRoteiro { get; set; }
        public string CodigoRoteiro { get; set; }
        public string Descricao { get; set; }
        public int SLAPadrao { get; set; }
        public DateTime Atualizacao { get; set; }
        public int IdUsuarioAtualizacao { get; set; }
    }
}
