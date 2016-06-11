using System;
using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica 
{                                                                  
    [DataContract]
    public class ListarCentroCustoRequest : RequestBase
    {
        [DataMember]
        public String CentroCusto { get; set; }
        [DataMember]
        public String Empresa { get; set; }
        [DataMember]
        public String Filial { get; set; }                                                  
    }                                                              
}                                                                  
