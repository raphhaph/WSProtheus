using System.Collections.Generic;
using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica
{
    [DataContract]
    public class ListarAgenciasBancoResponse : ResponseBase
   {
        
        [DataMember]
        public List<Models.AgenciaBanco> Agencias { get; set; }

   }
}
