using System;
using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    [DataContract]
    public class RecolhimentoFGTS
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descricao { get; set; }
        [DataMember]
        public Decimal Referencia { get; set; }
        [DataMember]
        public Decimal Valor { get; set; }
    }
}
