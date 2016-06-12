using System;
using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica 
{                                                                  
    [DataContract]
    public class ListarCidadesRequest : RequestBase
    {
        [DataMember]
        public String UF { get; set; }
        [DataMember]
        public String Empresa { get; set; }                                                 
    }                                                              
}                                                                  
