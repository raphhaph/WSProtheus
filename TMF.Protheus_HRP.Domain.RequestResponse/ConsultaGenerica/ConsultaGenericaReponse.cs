using System.Collections.Generic;
using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.ConsultaGenerica
{
    [DataContract]
    public class ConsultaGenericaReponse : ResponseBase
   {
        
        [DataMember]
        public List<Models.DadoGenerico> Dados { get; set; }

   }
}
