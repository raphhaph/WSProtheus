using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;
using TMF.Protheus_HRP.Domain.RequestResponse.Models;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo 
{                                                                  
    [DataContract]
    public class BuscarDemonstrativoRequest : RequestBase
    {
        [DataMember]
        public string CodigoEmpresa { get; set; }
        [DataMember]
        public string CodigoFilial { get; set; }
        [DataMember]
        public string Matricula { get; set; }
        [DataMember]
        public string Periodo { get; set; }
        [DataMember]
        public TipoDemonstrativo TipoDemonstrativo { get; set; }
    }                                                           
}                                                                  
