using System;

namespace TMF.Protheus_HRP.Domain.DTO
{
    public class RecolhimentoFGTS
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public Decimal Referencia { get; set; }
        public Decimal Valor { get; set; }
    }
}
