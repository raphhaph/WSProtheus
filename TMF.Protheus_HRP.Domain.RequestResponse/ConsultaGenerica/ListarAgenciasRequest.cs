using System;
using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica 
{                                                                  
    [DataContract]                                                 
    public class ListarAgenciasRequest : RequestBase
    {
        [DataMember]
        public String CodigoBanco { get; set; }
        [DataMember]
        public String Empresa { get; set; }
        [DataMember]
        public String Filial { get; set; }                                                  
    }                                                              
}                                                                  
