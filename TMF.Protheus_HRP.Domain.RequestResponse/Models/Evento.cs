using System;
using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    [DataContract]
    public class Evento
    {

        [DataMember]
        public string CodigoRubrica { get; set; }
        [DataMember]

        public string DescricaoRubrica { get; set; }
        [DataMember]

        public Decimal Quantidade { get; set; }
        [DataMember]

        public Decimal Valor { get; set; }
        [DataMember]

        public Decimal Desconto { get; set; }
        [DataMember]
       
        public string Base { get; set; }
    }
}
