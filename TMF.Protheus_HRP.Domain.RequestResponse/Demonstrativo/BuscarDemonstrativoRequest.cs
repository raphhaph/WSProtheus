using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;
using TMF.Protheus_HRP.Domain.RequestResponse.Models;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Demonstrativo 
{                                                                  
    [DataContract]
    public class BuscarDemonstrativoRequest : RequestBase
    {
        public string CodigoEmpresa { get; set; }
        public string CodigoFilial { get; set; }
        public string Matricula { get; set; }
        public string Periodo { get; set; }
        public TipoDemonstrativo TipoDemonstrativo { get; set; }
    }                                                           
}                                                                  
